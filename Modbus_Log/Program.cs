using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modbus_log.BL;

namespace Modbus_Log
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Main form = new Main();
            TCP maneger = new TCP();
            XMLSetting setting = new XMLSetting();
            MainPresenter presenter = new MainPresenter(form, maneger, setting);
            
            Application.Run(form);
        }
    }
}
