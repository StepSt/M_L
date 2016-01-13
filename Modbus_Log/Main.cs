using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
