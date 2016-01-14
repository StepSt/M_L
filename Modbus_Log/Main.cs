﻿using System;
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


namespace Modbus_Log
{
    #region Интерфейс для общения с презентором
    public interface IMainForm
    {
        string IPAddress { get; }
        string startAddress { get; }
        string numInputs { get; }
        string slaveID { get; }
        int cbTypes { get; }
        void ReadFloat(float value);
        event EventHandler ReadBtnClick;
    }
    #endregion
    public partial class Main : Form, IMainForm // объявление интерфейса
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();
        public Main()
        {
            InitializeComponent();
            _logger.Log(LogLevel.Info, "Запуск приложения"); //использование логгера
            btnRead.Click += new EventHandler(btnRead_Click);
        }
        #region Проброс событий
        void btnRead_Click (object sender, EventArgs e)
        {
            if (btnRead != null) ReadBtnClick(this, EventArgs.Empty);
        }
        #endregion
        #region IMainForm
        public string IPAddress
        {
            get { return txtIPAddress.Text; }
        }
        public string startAddress
        {
            get { return txtReadModbusAddress.Text; }
        }
        public string numInputs
        {
            get { return txtReadModbusCount.Text; }
        }
        public string slaveID
        {
            get { return txtSlaveId.Text; }
        }
        public int cbTypes
        {
            get { return intcbTypes.SelectedIndex; }
        }
        public void ReadFloat (float value)
        {
            txtReadRegisterValue.Text = value.ToString();
        }
        
        public event EventHandler ReadBtnClick;
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
    }
}
