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
                byte slaveID = Convert.ToByte(txtSlaveId.Text);
                try
                {
                    ushort[] inputs = master.ReadHoldingRegisters(slaveID, startAddress, numInputs);
                   try
                   {
                       TCP GetFloat = new TCP();

                       switch (cbTypes.SelectedIndex)
                       {
                           case 0:
                               foreach (ushort us in inputs)
                                   txtReadRegisterValue.Text = us.ToString();
                               break;
                           case 1:
                               // Из 2-х прочитанных ushort собираем 1 float
                               txtReadRegisterValue.Text = Convert.ToString (GetFloat.GetFloatTcp(inputs)); 
                               _logger.Log(LogLevel.Info, "Прочитал значнеи типа float " + txtReadRegisterValue.Text);
                               break;
                           case 2:
                               // Из 2-х прочитанных ushort собираем 1 float inverse
                               txtReadRegisterValue.Text = Convert.ToString (GetFloat.GetFloatInverseTcp(inputs)); 
                               _logger.Log(LogLevel.Info, "Прочитал значнеи типа float inverse " + txtReadRegisterValue.Text);
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
