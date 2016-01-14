using System;
using System.Linq;
using Modbus;
using Modbus.Device;
using NLog;

namespace Modbus_log.BL
{
    public class TCP:ITCP
    {
        private ModbusIpMaster masterIP;
        public TCP()
        {

        }//конструктор по умолчанию

        public TCP(ModbusIpMaster _masterIP)
        {
            masterIP = _masterIP;
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
