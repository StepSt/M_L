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
            this.intcbTypes = new System.Windows.Forms.ComboBox();
            this.txtReadMessege = new System.Windows.Forms.TextBox();
            this.txtReadRegisterValue = new System.Windows.Forms.TextBox();
            this.txtReadModbusAddress = new System.Windows.Forms.TextBox();
            this.txtReadModbusCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btReadXML = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnWriteModbusValue = new System.Windows.Forms.Button();
            this.txtWriteModbusValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWriteModbusAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.LBIPAddress = new System.Windows.Forms.Label();
            this.SlaveId = new System.Windows.Forms.Label();
            this.txtSlaveId = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFilepach = new System.Windows.Forms.TextBox();
            this.btRead = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.intcbTypes);
            this.groupBox2.Controls.Add(this.txtReadMessege);
            this.groupBox2.Controls.Add(this.btRead);
            this.groupBox2.Controls.Add(this.txtReadRegisterValue);
            this.groupBox2.Controls.Add(this.txtReadModbusAddress);
            this.groupBox2.Controls.Add(this.txtReadModbusCount);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(11, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 175);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Чтение";
            // 
            // intcbTypes
            // 
            this.intcbTypes.FormattingEnabled = true;
            this.intcbTypes.Items.AddRange(new object[] {
            "Int",
            "Float",
            "Float inverse"});
            this.intcbTypes.Location = new System.Drawing.Point(58, 64);
            this.intcbTypes.Name = "intcbTypes";
            this.intcbTypes.Size = new System.Drawing.Size(98, 21);
            this.intcbTypes.TabIndex = 7;
            this.intcbTypes.Text = "Float";
            // 
            // txtReadMessege
            // 
            this.txtReadMessege.Location = new System.Drawing.Point(6, 139);
            this.txtReadMessege.Name = "txtReadMessege";
            this.txtReadMessege.Size = new System.Drawing.Size(151, 20);
            this.txtReadMessege.TabIndex = 6;
            // 
            // txtReadRegisterValue
            // 
            this.txtReadRegisterValue.Location = new System.Drawing.Point(84, 96);
            this.txtReadRegisterValue.Name = "txtReadRegisterValue";
            this.txtReadRegisterValue.ReadOnly = true;
            this.txtReadRegisterValue.Size = new System.Drawing.Size(73, 20);
            this.txtReadRegisterValue.TabIndex = 4;
            this.txtReadRegisterValue.Text = "0";
            // 
            // txtReadModbusAddress
            // 
            this.txtReadModbusAddress.Location = new System.Drawing.Point(58, 12);
            this.txtReadModbusAddress.Name = "txtReadModbusAddress";
            this.txtReadModbusAddress.Size = new System.Drawing.Size(99, 20);
            this.txtReadModbusAddress.TabIndex = 4;
            this.txtReadModbusAddress.Text = "0";
            // 
            // txtReadModbusCount
            // 
            this.txtReadModbusCount.Location = new System.Drawing.Point(58, 38);
            this.txtReadModbusCount.Name = "txtReadModbusCount";
            this.txtReadModbusCount.Size = new System.Drawing.Size(99, 20);
            this.txtReadModbusCount.TabIndex = 4;
            this.txtReadModbusCount.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Адрес";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Усли что-то пошло не так";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Тип";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Размер";
            // 
            // btReadXML
            // 
            this.btReadXML.Location = new System.Drawing.Point(168, 8);
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
            this.groupBox1.Location = new System.Drawing.Point(189, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 175);
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
            this.btnWriteModbusValue.Click += new System.EventHandler(this.btnWriteModbusValue_Click);
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
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(9, 29);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(112, 20);
            this.txtIPAddress.TabIndex = 4;
            this.txtIPAddress.Text = "127.0.0.1";
            // 
            // LBIPAddress
            // 
            this.LBIPAddress.AutoSize = true;
            this.LBIPAddress.Location = new System.Drawing.Point(12, 9);
            this.LBIPAddress.Name = "LBIPAddress";
            this.LBIPAddress.Size = new System.Drawing.Size(55, 13);
            this.LBIPAddress.TabIndex = 3;
            this.LBIPAddress.Text = "IPAddress";
            // 
            // SlaveId
            // 
            this.SlaveId.AutoSize = true;
            this.SlaveId.Location = new System.Drawing.Point(140, 9);
            this.SlaveId.Name = "SlaveId";
            this.SlaveId.Size = new System.Drawing.Size(43, 13);
            this.SlaveId.TabIndex = 3;
            this.SlaveId.Text = "SlaveId";
            // 
            // txtSlaveId
            // 
            this.txtSlaveId.Location = new System.Drawing.Point(137, 29);
            this.txtSlaveId.Name = "txtSlaveId";
            this.txtSlaveId.Size = new System.Drawing.Size(112, 20);
            this.txtSlaveId.TabIndex = 4;
            this.txtSlaveId.Text = "1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtFilepach);
            this.groupBox3.Controls.Add(this.btReadXML);
            this.groupBox3.Location = new System.Drawing.Point(12, 249);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 96);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Настройки";
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
            // txtFilepach
            // 
            this.txtFilepach.Location = new System.Drawing.Point(48, 13);
            this.txtFilepach.Name = "txtFilepach";
            this.txtFilepach.Size = new System.Drawing.Size(112, 20);
            this.txtFilepach.TabIndex = 4;
            this.txtFilepach.Text = "modbus.xml";
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(10, 91);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(69, 29);
            this.btRead.TabIndex = 5;
            this.btRead.Text = "Прочитать";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 533);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSlaveId);
            this.Controls.Add(this.txtIPAddress);
            this.Controls.Add(this.SlaveId);
            this.Controls.Add(this.LBIPAddress);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtReadMessege;
        private System.Windows.Forms.TextBox txtReadRegisterValue;
        private System.Windows.Forms.TextBox txtReadModbusAddress;
        private System.Windows.Forms.TextBox txtReadModbusCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnWriteModbusValue;
        private System.Windows.Forms.TextBox txtWriteModbusValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWriteModbusAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.Label LBIPAddress;
        private System.Windows.Forms.Label SlaveId;
        private System.Windows.Forms.TextBox txtSlaveId;
        private System.Windows.Forms.ComboBox intcbTypes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btReadXML;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFilepach;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.Timer timer1;
    }
}

