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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtReadMessege = new System.Windows.Forms.TextBox();
            this.btnReadRegister = new System.Windows.Forms.Button();
            this.txtReadRegisterValue = new System.Windows.Forms.TextBox();
            this.txtReadModbusAddress = new System.Windows.Forms.TextBox();
            this.txtReadModbusCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnWriteModbusValue = new System.Windows.Forms.Button();
            this.txtWriteModbusValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWriteModbusAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.IPAddress = new System.Windows.Forms.Label();
            this.SlaveId = new System.Windows.Forms.Label();
            this.txtSlaveId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTypes = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbTypes);
            this.groupBox2.Controls.Add(this.txtReadMessege);
            this.groupBox2.Controls.Add(this.btnReadRegister);
            this.groupBox2.Controls.Add(this.txtReadRegisterValue);
            this.groupBox2.Controls.Add(this.txtReadModbusAddress);
            this.groupBox2.Controls.Add(this.txtReadModbusCount);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(11, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 223);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Чтение";
            // 
            // txtReadMessege
            // 
            this.txtReadMessege.Location = new System.Drawing.Point(137, 197);
            this.txtReadMessege.Name = "txtReadMessege";
            this.txtReadMessege.Size = new System.Drawing.Size(158, 20);
            this.txtReadMessege.TabIndex = 6;
            // 
            // btnReadRegister
            // 
            this.btnReadRegister.Location = new System.Drawing.Point(9, 149);
            this.btnReadRegister.Name = "btnReadRegister";
            this.btnReadRegister.Size = new System.Drawing.Size(69, 29);
            this.btnReadRegister.TabIndex = 5;
            this.btnReadRegister.Text = "Прочитать";
            this.btnReadRegister.UseVisualStyleBackColor = true;
            this.btnReadRegister.Click += new System.EventHandler(this.btnReadRegister_Click);
            // 
            // txtReadRegisterValue
            // 
            this.txtReadRegisterValue.Location = new System.Drawing.Point(99, 154);
            this.txtReadRegisterValue.Name = "txtReadRegisterValue";
            this.txtReadRegisterValue.ReadOnly = true;
            this.txtReadRegisterValue.Size = new System.Drawing.Size(73, 20);
            this.txtReadRegisterValue.TabIndex = 4;
            this.txtReadRegisterValue.Text = "0";
            // 
            // txtReadModbusAddress
            // 
            this.txtReadModbusAddress.Location = new System.Drawing.Point(156, 34);
            this.txtReadModbusAddress.Name = "txtReadModbusAddress";
            this.txtReadModbusAddress.Size = new System.Drawing.Size(73, 20);
            this.txtReadModbusAddress.TabIndex = 4;
            this.txtReadModbusAddress.Text = "0";
            // 
            // txtReadModbusCount
            // 
            this.txtReadModbusCount.Location = new System.Drawing.Point(28, 34);
            this.txtReadModbusCount.Name = "txtReadModbusCount";
            this.txtReadModbusCount.Size = new System.Drawing.Size(73, 20);
            this.txtReadModbusCount.TabIndex = 4;
            this.txtReadModbusCount.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Адрес";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Усли что-то пошло не так";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Размер";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnWriteModbusValue);
            this.groupBox1.Controls.Add(this.txtWriteModbusValue);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtWriteModbusAddress);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(9, 436);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 138);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Запись";
            // 
            // btnWriteModbusValue
            // 
            this.btnWriteModbusValue.Location = new System.Drawing.Point(40, 78);
            this.btnWriteModbusValue.Name = "btnWriteModbusValue";
            this.btnWriteModbusValue.Size = new System.Drawing.Size(69, 29);
            this.btnWriteModbusValue.TabIndex = 5;
            this.btnWriteModbusValue.Text = "Записать";
            this.btnWriteModbusValue.UseVisualStyleBackColor = true;
            this.btnWriteModbusValue.Click += new System.EventHandler(this.btnWriteModbusValue_Click);
            // 
            // txtWriteModbusValue
            // 
            this.txtWriteModbusValue.Location = new System.Drawing.Point(37, 45);
            this.txtWriteModbusValue.Name = "txtWriteModbusValue";
            this.txtWriteModbusValue.Size = new System.Drawing.Size(73, 20);
            this.txtWriteModbusValue.TabIndex = 4;
            this.txtWriteModbusValue.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Значение";
            // 
            // txtWriteModbusAddress
            // 
            this.txtWriteModbusAddress.Location = new System.Drawing.Point(165, 45);
            this.txtWriteModbusAddress.Name = "txtWriteModbusAddress";
            this.txtWriteModbusAddress.Size = new System.Drawing.Size(73, 20);
            this.txtWriteModbusAddress.TabIndex = 4;
            this.txtWriteModbusAddress.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 27);
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
            // IPAddress
            // 
            this.IPAddress.AutoSize = true;
            this.IPAddress.Location = new System.Drawing.Point(12, 9);
            this.IPAddress.Name = "IPAddress";
            this.IPAddress.Size = new System.Drawing.Size(55, 13);
            this.IPAddress.TabIndex = 3;
            this.IPAddress.Text = "IPAddress";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Тип";
            // 
            // cbTypes
            // 
            this.cbTypes.FormattingEnabled = true;
            this.cbTypes.Items.AddRange(new object[] {
            "Int",
            "Float",
            "Float inverse"});
            this.cbTypes.Location = new System.Drawing.Point(28, 73);
            this.cbTypes.Name = "cbTypes";
            this.cbTypes.Size = new System.Drawing.Size(88, 21);
            this.cbTypes.TabIndex = 7;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 604);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSlaveId);
            this.Controls.Add(this.txtIPAddress);
            this.Controls.Add(this.SlaveId);
            this.Controls.Add(this.IPAddress);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtReadMessege;
        private System.Windows.Forms.Button btnReadRegister;
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
        private System.Windows.Forms.Label IPAddress;
        private System.Windows.Forms.Label SlaveId;
        private System.Windows.Forms.TextBox txtSlaveId;
        private System.Windows.Forms.ComboBox cbTypes;
        private System.Windows.Forms.Label label6;
    }
}

