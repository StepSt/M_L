using System;
using System.Linq;
using System.Net.Sockets;
using Modbus;
using Modbus.Device;
using NLog;

namespace Modbus_log.BL
{
    public class TCP:ITCP
    {
        private TcpClient clientIP;
        private ModbusIpMaster masterIP;
        public TCP()
        {
        }
        public TCP(string IPAddress)
        {
            clientIP = new TcpClient(IPAddress, 502);
            ModbusIpMaster master = ModbusIpMaster.CreateIp(clientIP);
            masterIP = master;
        }
        public float GetFloat(byte slaveAddress, ushort startAddress, ushort numberOfPoints)
        {
            float value = 0;
            if (masterIP!=null)
            {
                ushort[] inputs = masterIP.ReadHoldingRegisters(slaveAddress, startAddress, numberOfPoints);
                value = BitConverter.ToSingle(BitConverter.GetBytes(inputs[0]).Concat(BitConverter.GetBytes(inputs[1])).ToArray(), 0);
            }
            return value;
        }
        public float GetFloatInverse(byte slaveAddress, ushort startAddress, ushort numberOfPoints)
        {
            float value = 0;
            if (masterIP != null)
            {
                ushort[] inputs = masterIP.ReadHoldingRegisters(slaveAddress, startAddress, numberOfPoints);
                value = BitConverter.ToSingle(BitConverter.GetBytes(inputs[1]).Concat(BitConverter.GetBytes(inputs[0])).ToArray(), 0);
            }

            return value;
        }

    }
}
