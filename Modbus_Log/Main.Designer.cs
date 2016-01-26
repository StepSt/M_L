namespace Modbus_Log
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_ValueModbus = new System.Windows.Forms.DataGridView();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btRead = new System.Windows.Forms.Button();
            this.btReadXML = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnWriteModbusValue = new System.Windows.Forms.Button();
            this.txtWriteModbusValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWriteModbusAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtFilepach = new System.Windows.Forms.TextBox();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ValueModbus)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_ValueModbus);
            this.groupBox2.Controls.Add(this.btRead);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 294);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Чтение";
            // 
            // dataGridView_ValueModbus
            // 
            this.dataGridView_ValueModbus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ValueModbus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Value});
            this.dataGridView_ValueModbus.Location = new System.Drawing.Point(9, 19);
            this.dataGridView_ValueModbus.Name = "dataGridView_ValueModbus";
            this.dataGridView_ValueModbus.Size = new System.Drawing.Size(148, 89);
            this.dataGridView_ValueModbus.TabIndex = 8;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(97, 259);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(69, 29);
            this.btRead.TabIndex = 5;
            this.btRead.Text = "Прочитать";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btReadXML
            // 
            this.btReadXML.Location = new System.Drawing.Point(275, 13);
            this.btReadXML.Name = "btReadXML";
            this.btReadXML.Size = new System.Drawing.Size(69, 29);
            this.btReadXML.TabIndex = 5;
            this.btReadXML.Text = "Прочитать";
            this.btReadXML.UseVisualStyleBackColor = true;
            this.btReadXML.Click += new System.EventHandler(this.btnReadXML_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnWriteModbusValue);
            this.groupBox1.Controls.Add(this.txtWriteModbusValue);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtWriteModbusAddress);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(666, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 294);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Запись";
            // 
            // btnWriteModbusValue
            // 
            this.btnWriteModbusValue.Location = new System.Drawing.Point(9, 91);
            this.btnWriteModbusValue.Name = "btnWriteModbusValue";
            this.btnWriteModbusValue.Size = new System.Drawing.Size(69, 29);
            this.btnWriteModbusValue.TabIndex = 5;
            this.btnWriteModbusValue.Text = "Записать";
            this.btnWriteModbusValue.UseVisualStyleBackColor = true;
            // 
            // txtWriteModbusValue
            // 
            this.txtWriteModbusValue.Location = new System.Drawing.Point(66, 38);
            this.txtWriteModbusValue.Name = "txtWriteModbusValue";
            this.txtWriteModbusValue.Size = new System.Drawing.Size(73, 20);
            this.txtWriteModbusValue.TabIndex = 4;
            this.txtWriteModbusValue.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Значение";
            // 
            // txtWriteModbusAddress
            // 
            this.txtWriteModbusAddress.Location = new System.Drawing.Point(66, 13);
            this.txtWriteModbusAddress.Name = "txtWriteModbusAddress";
            this.txtWriteModbusAddress.Size = new System.Drawing.Size(73, 20);
            this.txtWriteModbusAddress.TabIndex = 4;
            this.txtWriteModbusAddress.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Адрес";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtid);
            this.groupBox3.Controls.Add(this.txtFilepach);
            this.groupBox3.Controls.Add(this.btReadXML);
            this.groupBox3.Location = new System.Drawing.Point(12, 312);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 96);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Настройки";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Количество";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Файл";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(77, 39);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(112, 20);
            this.txtid.TabIndex = 4;
            this.txtid.Text = "2";
            // 
            // txtFilepach
            // 
            this.txtFilepach.Location = new System.Drawing.Point(48, 13);
            this.txtFilepach.Name = "txtFilepach";
            this.txtFilepach.Size = new System.Drawing.Size(112, 20);
            this.txtFilepach.TabIndex = 4;
            this.txtFilepach.Text = "modbus.xml";
            // 
            // zedGraph
            // 
            this.zedGraph.Location = new System.Drawing.Point(190, 25);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(470, 275);
            this.zedGraph.TabIndex = 8;
            this.zedGraph.UseExtendedPrintDialog = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 430);
            this.Controls.Add(this.zedGraph);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ValueModbus)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnWriteModbusValue;
        private System.Windows.Forms.TextBox txtWriteModbusValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWriteModbusAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btReadXML;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFilepach;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.DataGridView dataGridView_ValueModbus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

