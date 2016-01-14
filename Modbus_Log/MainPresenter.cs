using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using Modbus.Device;
using Modbus;
using Modbus_log.BL;

namespace Modbus_Log
{
    class MainPresenter
    {
        private readonly IMainForm _view;
        private readonly ITCP _tcp;

        public MainPresenter (IMainForm view, ITCP tcp)
        {
            _view = view;
            _tcp = tcp;

            _view.ReadBtnClick += _view_ReadBtnClick;
        }

        void _view_ReadBtnClick(object sender, EventArgs e)
        {
            string view_IPAddress = _view.IPAddress;
            string view_startAddress = _view.startAddress;
            string view_numInputs = _view.numInputs;
            string view_slaveID = _view.slaveID;
            int view_cbTypes = _view.cbTypes;

            using (TcpClient client = new TcpClient(view_IPAddress, 502))
            {

                ModbusIpMaster master = ModbusIpMaster.CreateIp(client);

                ushort startAddress = Convert.ToUInt16(view_startAddress);
                ushort numInputs = Convert.ToUInt16(view_numInputs);
                byte slaveID = Convert.ToByte(view_slaveID);
        try
            {
                ushort[] inputs = master.ReadHoldingRegisters(slaveID, startAddress, numInputs);
                switch (view_cbTypes)
                {
                    //case 0:
                    //    foreach (ushort us in inputs)
                    //        txtReadRegisterValue.Text = us.ToString();
                    //    break;
                    case 1:
                        // Из 2-х прочитанных ushort собираем 1 float
                        float value = _tcp.GetFloatTcp(inputs);
                        _view.ReadFloat(value);
                        break;
                    case 2:
                        // Из 2-х прочитанных ushort собираем 1 float inverse
                        value = _tcp.GetFloatInverseTcp(inputs);
                        _view.ReadFloat(value);
                        break;
                    default:
                        MessageBox.Show("Выберете тип переменной!");
                        break;
                }
            }
        catch (IndexOutOfRangeException)
        {
            MessageBox.Show("Размер не может быть =1");
        }


            }
        }
    }
}
