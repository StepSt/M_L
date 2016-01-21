using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modbus_log.BL
{
    public interface InXMLSetting
    {
        XMLSetting_var ReadXMLDocument(string filepath, string pid);
    }
}
