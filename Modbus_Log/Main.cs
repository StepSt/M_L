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
using NLog;
using Modbus_log.BL;

using System.Xml;
using System.IO;


namespace Modbus_Log
{
    #region Интерфейс для общения с презентором
    public interface IMainForm
    {
        float ReadFloat(float value);
        string id { get; }

        DataGridView valuesModbus { get; }

        event EventHandler ReadBtnClick;
        event EventHandler ReadXMLClick;

        string filepach { get; }
    }
    #endregion
    public partial class Main : Form, IMainForm // объявление интерфейса
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();
        public Main()
        {
            InitializeComponent();
            _logger.Log(LogLevel.Info, "Запуск приложения"); //использование логгера
            btRead.Click += new EventHandler(btnRead_Click);
            btReadXML.Click += new EventHandler(btnReadXML_Click);
        }
        #region Проброс событий
        void btnRead_Click (object sender, EventArgs e)
        {
            if (btRead != null) ReadBtnClick(this, EventArgs.Empty);
        }
        void btnReadXML_Click(object sender, EventArgs ex)
        {
            while (dataGridView_ValueModbus.Rows.Count < Convert.ToInt32(id))
            {
                dataGridView_ValueModbus.Rows.Add();
            }
            ReadXMLClick(this, EventArgs.Empty); 
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ReadBtnClick(this, EventArgs.Empty);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            while (dataGridView_ValueModbus.Rows.Count < Convert.ToInt32(id))
            {
                dataGridView_ValueModbus.Rows.Add();
            }
            ReadXMLClick(this, EventArgs.Empty);
        }
        #endregion
        #region IMainForm
        public string id
        {
            get { return txtid.Text;}
        }

        public DataGridView valuesModbus
        {
            get { return dataGridView_ValueModbus; }
        }

        public float ReadFloat (float value)
        {
            return value;
        }
        
        public event EventHandler ReadBtnClick;
        public event EventHandler ReadXMLClick;

        public string filepach
        {
            get { return txtFilepach.Text; }
        }
        #endregion
        #region Работающий спагетти код
        //private void btnWriteModbusValue_Click(object sender, EventArgs e)
        //{
        //    using (TcpClient client = new TcpClient(txtIPAddress.Text, 502))
        //    {
        //        ModbusIpMaster master = ModbusIpMaster.CreateIp(client);

        //        ushort startAddress = Convert.ToUInt16(txtWriteModbusAddress.Text);
        //        ushort numInputs = Convert.ToUInt16(txtWriteModbusValue.Text);

        //        master.WriteSingleRegister(startAddress, numInputs);

        //    }
        //}
        #endregion
    }
}
