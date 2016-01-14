using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modbus_log.BL
{
    public interface ITCP
    {

        float GetFloat(byte slaveAddress, ushort startAddress, ushort numberOfPoints);
        float GetFloatInverse(byte slaveAddress, ushort startAddress, ushort numberOfPoints);

    }
}
