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
        public XMLSetting_var[] set = new XMLSetting_var[99];

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

            for (int i = 0; i < Convert.ToInt32(_view.id); i++)
            {
                set[i] = _xmlsetting.ReadXMLDocument(_view.filepach, i.ToString());
            }
        }
        void _view_ReadBtnClick(object sender, EventArgs e)
        {
            for (int i = 0; i < Convert.ToInt32(_view.id); i++)
            {
                _tcp = new TCP(set[i].IPAddress);
                try
                {
                        switch (set[i].cbTypes)
                        {
                            case 1:
                                float val = _view.ReadFloat(_tcp.GetFloat(Convert.ToByte(set[i].slaveID), Convert.ToUInt16(set[i].startAddress), Convert.ToUInt16(set[i].numInputs)));
                                _view.valuesModbus.Rows[i].Cells[0 ].Value = val;
                                break;
                            case 2:
                                _view.ReadFloat(_tcp.GetFloatInverse(Convert.ToByte(set[i].slaveID), Convert.ToUInt16(set[i].startAddress), Convert.ToUInt16(set[i].numInputs)));
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
}
