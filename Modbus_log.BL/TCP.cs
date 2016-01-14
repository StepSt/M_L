using System;
using System.Linq;

using Modbus.Device;
using Modbus;
using NLog;

namespace Modbus_log.BL
{
    public interface ITCP
    {
        float GetFloatTcp(ushort[] inputs);
        float GetFloatInverseTcp(ushort[] inputs);
    }
    public class TCP:ITCP
    {
        
        public float GetFloatTcp( ushort[] inputs )
        {
            float value = BitConverter.ToSingle(BitConverter.GetBytes(inputs[0]).Concat(BitConverter.GetBytes(inputs[1])).ToArray(), 0);
            return value;
        }
        public float GetFloatInverseTcp(ushort[] inputs)
        {
            float value = BitConverter.ToSingle(BitConverter.GetBytes(inputs[1]).Concat(BitConverter.GetBytes(inputs[0 ])).ToArray(), 0);
            return value;
        }
    }
}
