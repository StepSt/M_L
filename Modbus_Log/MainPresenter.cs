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
        private InXMLSetting _xmlsetting;

        public MainPresenter (IMainForm view, ITCP tcp, InXMLSetting xmlsetting)
        {
            _view = view;
            _tcp = tcp;
            _xmlsetting = xmlsetting;

            _view.ReadBtnClick += _view_ReadBtnClick;
            _view.ReadXMLClick +=_view_ReadXMLClick;
        }

        void _view_ReadXMLClick(object sender, EventArgs e)
        {
            _xmlsetting = new XMLSetting(_view.filepach);
            XMLSetting_var set = new XMLSetting_var();
            set = _xmlsetting.ReadXMLDocument(_view.filepach, "1");
            _view.IPAddress = set.IPAddress;
            _view.startAddress = set.startAddress;
            _view.slaveID = set.slaveID;
            _view.numInputs = set.numInputs;
        }
        void _view_ReadBtnClick(object sender, EventArgs e)
        {
             _tcp = new TCP(_view.IPAddress);
            string view_startAddress = _view.startAddress;
            string view_numInputs = _view.numInputs;
            string view_slaveID = _view.slaveID;
            int view_cbTypes = _view.cbTypes;

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
                    MessageBox.Show("Размер не может быть = 1");
                }
        }
    }
}
