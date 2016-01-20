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
        string IPAddress { get; set; }
        string startAddress { get; set; }
        string numInputs { get; set; }
        string slaveID { get; set; }
        int cbTypes { get; set; }
        void ReadFloat(float value);
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
            ReadXMLClick(this, EventArgs.Empty); 
        }
        #endregion
        #region IMainForm
        public string IPAddress
        {
            get { return txtIPAddress.Text; }
            set { txtIPAddress.Text = value; }
        }
        public string startAddress
        {
            get { return txtReadModbusAddress.Text; }
            set { txtReadModbusAddress.Text = value; }
        }
        public string numInputs
        {
            get { return txtReadModbusCount.Text; }
            set { txtReadModbusCount.Text = value; }
        }
        public string slaveID
        {
            get { return txtSlaveId.Text; }
            set { txtSlaveId.Text = value; }
        }
        public int cbTypes
        {
            get { return intcbTypes.SelectedIndex; }
            set { intcbTypes.SelectedIndex = value; }
        }
        public void ReadFloat (float value)
        {
            txtReadRegisterValue.Text = value.ToString();
        }
        
        public event EventHandler ReadBtnClick;
        public event EventHandler ReadXMLClick;

        public string filepach
        {
            get { return txtFilepach.Text; }
        }
        #endregion

        #region Работающий спагетти код
        private void btnWriteModbusValue_Click(object sender, EventArgs e)
        {
            using (TcpClient client = new TcpClient(txtIPAddress.Text, 502))
            {
                ModbusIpMaster master = ModbusIpMaster.CreateIp(client);

                ushort startAddress = Convert.ToUInt16(txtWriteModbusAddress.Text);
                ushort numInputs = Convert.ToUInt16(txtWriteModbusValue.Text);

                master.WriteSingleRegister(startAddress, numInputs);

            }
        }
        #endregion

              private void timer1_Tick(object sender, EventArgs e)
        {
            ReadBtnClick(this, EventArgs.Empty);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ReadXMLClick(this, EventArgs.Empty); 
        }
    }
}
