using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace Modbus_log.BL
{
    public class XMLSetting:InXMLSetting
    {
        private XmlDocument xd = new XmlDocument();
        public XMLSetting()
        {

        }
        public XMLSetting(string filepath)
        {
            FileStream fs = new FileStream(filepath, FileMode.Open);
            XmlDocument _xd = new XmlDocument();
            _xd.Load(fs);
            xd = _xd;
            fs.Close();
        }
        public XMLSetting_var ReadXMLDocument(string filepath, string pid)
        {
            XmlNodeList list = xd.GetElementsByTagName("tag"); // Создаем и заполняем лист по тегу "user"
            XMLSetting_var setting = new XMLSetting_var();
            for (int i = 0; i < list.Count; i++)
            {
                XmlElement id = (XmlElement)xd.GetElementsByTagName("tag")[i];         // Забиваем id в переменную  
                XmlElement IPAdress = (XmlElement)xd.GetElementsByTagName("IPAdress")[i];      //  
                XmlElement SlaveID = (XmlElement)xd.GetElementsByTagName("SlaveID")[i];   // Забиваем
                XmlElement Adress = (XmlElement)xd.GetElementsByTagName("Adress")[i];
                XmlElement Num = (XmlElement)xd.GetElementsByTagName("Num")[i];
                XmlElement Types = (XmlElement)xd.GetElementsByTagName("Types")[i];
                string tsst_id = id.GetAttribute("id");

                if (id.GetAttribute("id") == pid) // Если наткнулся на нужный айдишник  
                {
                    // Вставляем в переменные текст из тегов
                    setting.IPAddress = IPAdress.InnerText;
                    setting.startAddress = Adress.InnerText;
                    setting.slaveID = SlaveID.InnerText;
                    setting.numInputs = Num.InnerText;
                    switch (Types.InnerText)
                    {
                        case "Float":
                            setting.cbTypes = 1;
                            break;
                    }
                }
            }
            return setting;
        }

    }
}
