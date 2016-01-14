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
        private ITCP _tcp;

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
                _tcp = new TCP(master);
                try
                {
                    switch (view_cbTypes)
                    {
                        case 1:
                            _view.ReadFloat(_tcp.GetFloat(Convert.ToByte(view_slaveID), Convert.ToUInt16(view_startAddress), Convert.ToUInt16(view_numInputs)));
                            break;
                        case 2:
                            _view.ReadFloat(_tcp.GetFloatInverse(Convert.ToByte(view_slaveID), Convert.ToUInt16(view_startAddress), Convert.ToUInt16(view_numInputs)));
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
