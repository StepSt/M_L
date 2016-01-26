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

using System.Xml;
using System.IO;

using ZedGraph;
using System.Drawing;


namespace Modbus_Log
{
    #region Интерфейс для общения с презентором
    public interface IMainForm
    {
        float ReadFloat(float value);
        string id { get; }

        DataGridView valuesModbus { get; }

        event EventHandler ReadBtnClick;
        event EventHandler ReadXMLClick;

        string filepach { get; }
    }
    #endregion
    public partial class Main : Form, IMainForm // объявление интерфейса
    {
        #region Кусок Трендов
        int _capacity = 100;
        RollingPointPairList _data;
        double _amplitude = 20;
        #endregion
        private static Logger _logger = LogManager.GetCurrentClassLogger();
        public Main()
        {
            InitializeComponent();
            _logger.Log(LogLevel.Info, "Запуск приложения"); //использование логгера
            btRead.Click += new EventHandler(btnRead_Click);
            btReadXML.Click += new EventHandler(btnReadXML_Click);
        }
        #region Проброс событий
        void btnRead_Click (object sender, EventArgs e)
        {
            if (btRead != null) ReadBtnClick(this, EventArgs.Empty);
        }
        void btnReadXML_Click(object sender, EventArgs ex)
        {
            while (dataGridView_ValueModbus.Rows.Count < Convert.ToInt32(id))
            {
                dataGridView_ValueModbus.Rows.Add();
            }
            ReadXMLClick(this, EventArgs.Empty); 
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ReadBtnClick(this, EventArgs.Empty);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            #region Кусок трендов
            // !!! Создаем массив данных с ограниченной емкостью.
            // При превышениизаданной емкости первые элементы в массиве будут удаляться
            _data = new RollingPointPairList(_capacity);
            PrepareGraph();
            #endregion
            while (dataGridView_ValueModbus.Rows.Count < Convert.ToInt32(id))
            {
                dataGridView_ValueModbus.Rows.Add();
            }
            ReadXMLClick(this, EventArgs.Empty);
        }
        #endregion
        #region IMainForm
        public string id
        {
            get { return txtid.Text;}
        }

        public DataGridView valuesModbus
        {
            get { return dataGridView_ValueModbus; }
        }

        public float ReadFloat (float value)
        {
            return value;
        }
        
        public event EventHandler ReadBtnClick;
        public event EventHandler ReadXMLClick;

        public string filepach
        {
            get { return txtFilepach.Text; }
        }
        #endregion
        #region Работающий спагетти код
        //private void btnWriteModbusValue_Click(object sender, EventArgs e)
        //{
        //    using (TcpClient client = new TcpClient(txtIPAddress.Text, 502))
        //    {
        //        ModbusIpMaster master = ModbusIpMaster.CreateIp(client);

        //        ushort startAddress = Convert.ToUInt16(txtWriteModbusAddress.Text);
        //        ushort numInputs = Convert.ToUInt16(txtWriteModbusValue.Text);

        //        master.WriteSingleRegister(startAddress, numInputs);

        //    }
        //}
        #endregion
        #region Кусок трендов
        private void timer_Tick(object sender, EventArgs e)
        {
            // !!! Добавим новый отсчет к данным
            double newValue = Convert.ToDouble(dataGridView_ValueModbus.Rows[0].Cells[0].Value);

            DateTime startDate = new DateTime();
            startDate = DateTime.Now;
            DateTime currentDate = startDate.AddSeconds(1);

            // Рассчитаем интервал по оси X, который нужно отобразить на графике
            DateTime date0 = new DateTime();
            DateTime date1 = new DateTime();
            date0 = startDate.AddMinutes(-1);
            date1 = startDate.AddMinutes(5);
            XDate xmin = date0;
            XDate xmax = date1;

            GraphPane pane = zedGraph.GraphPane;
            pane.XAxis.Scale.Min = xmin;
            pane.XAxis.Scale.Max = xmax;
            _data.Add(new XDate(currentDate), newValue);
            // Обновим оси
            zedGraph.AxisChange();

            // Обновим сам график
            zedGraph.Invalidate();
        }


        /// <summary>
        /// Подготовка к отображению данных
        /// </summary>
        private void PrepareGraph()
        {
            // Получим панель для рисования
            GraphPane pane = zedGraph.GraphPane;

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            // Добавим кривую пока еще без каких-либо точек
            LineItem myCurve = pane.AddCurve("sin (x)", _data, Color.Blue, SymbolType.None);

            // Устанавливаем интересующий нас интервал по оси Y
            pane.YAxis.Scale.Min = -_amplitude;
            pane.YAxis.Scale.Max = _amplitude;

            pane.XAxis.Type = AxisType.Date;

            // Вызываем метод AxisChange (), чтобы обновить данные об осях. 
            zedGraph.AxisChange();

            // Обновляем график
            zedGraph.Invalidate();
        }
        #endregion
    }
}
