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

namespace Modbus_Log
{
    public partial class Main : Form
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();
        public Main()
        {
            InitializeComponent();
            _logger.Log(LogLevel.Info, "Запуск приложения");
        }
        private void btnReadRegister_Click(object sender, EventArgs e)
        {
            using (TcpClient client = new TcpClient(txtIPAddress.Text, 502))
            {
                ModbusIpMaster master = ModbusIpMaster.CreateIp(client);

                ushort startAddress = Convert.ToUInt16(txtReadModbusAddress.Text);
                ushort numInputs = Convert.ToUInt16(txtReadModbusCount.Text);

                try
                {
                    ushort[] inputs = master.ReadHoldingRegisters(startAddress, numInputs);
                    //SlaveException MNMess = new SlaveException();
                    //txtReadMessege.Text = MNMess.Message;

                    foreach (ushort us in inputs)
                        txtReadRegisterValue.Text = us.ToString();
                }
                catch (SlaveException ex)
                {
                    txtReadMessege.Text = Convert.ToString(ex.FunctionCode) + ";";
                    txtReadMessege.Text += Convert.ToString(ex.SlaveExceptionCode) + ";";
                }
            }
        }

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
    }
}
