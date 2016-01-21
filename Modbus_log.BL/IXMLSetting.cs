using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modbus_log.BL
{
    public interface IXMLSetting
    {
        ModbusSt ReadXMLDocument(string filepath, string pid);
    }
}
