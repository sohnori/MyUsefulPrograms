namespace SerialComm
{
    partial class Form2
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
            tabControl1 = new TabControl();
            tbSerial = new TabPage();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            cbTimeout = new ComboBox();
            cbPort = new ComboBox();
            textBox7 = new TextBox();
            textBox2 = new TextBox();
            cbFlowControl = new ComboBox();
            cbBaudrates = new ComboBox();
            textBox6 = new TextBox();
            textBox3 = new TextBox();
            cbStopBit = new ComboBox();
            cbDataBits = new ComboBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            cbParity = new ComboBox();
            tbSocket = new TabPage();
            groupBox1 = new GroupBox();
            textBox13 = new TextBox();
            textBox12 = new TextBox();
            ckbDomain = new CheckBox();
            ckbBrordcast = new CheckBox();
            textBox11 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            comboBox1 = new ComboBox();
            textBox10 = new TextBox();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            rbUdpC = new RadioButton();
            rbUdpS = new RadioButton();
            rbTcpC = new RadioButton();
            rbTcpS = new RadioButton();
            tabControl1.SuspendLayout();
            tbSerial.SuspendLayout();
            groupBox2.SuspendLayout();
            tbSocket.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tbSerial);
            tabControl1.Controls.Add(tbSocket);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(370, 272);
            tabControl1.TabIndex = 0;
            // 
            // tbSerial
            // 
            tbSerial.BackColor = Color.Gainsboro;
            tbSerial.Controls.Add(groupBox2);
            tbSerial.Location = new Point(4, 24);
            tbSerial.Name = "tbSerial";
            tbSerial.Padding = new Padding(3);
            tbSerial.Size = new Size(362, 244);
            tbSerial.TabIndex = 0;
            tbSerial.Text = "Serial(COM)";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(cbTimeout);
            groupBox2.Controls.Add(cbPort);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(cbFlowControl);
            groupBox2.Controls.Add(cbBaudrates);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(cbStopBit);
            groupBox2.Controls.Add(cbDataBits);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(cbParity);
            groupBox2.Location = new Point(6, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(277, 232);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Properties";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Gainsboro;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(6, 22);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(96, 16);
            textBox1.TabIndex = 0;
            textBox1.TabStop = false;
            textBox1.Text = "Port :";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // cbTimeout
            // 
            cbTimeout.FormattingEnabled = true;
            cbTimeout.Location = new Point(123, 193);
            cbTimeout.Name = "cbTimeout";
            cbTimeout.Size = new Size(121, 23);
            cbTimeout.TabIndex = 13;
            // 
            // cbPort
            // 
            cbPort.FormattingEnabled = true;
            cbPort.Location = new Point(123, 19);
            cbPort.Name = "cbPort";
            cbPort.Size = new Size(121, 23);
            cbPort.TabIndex = 1;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.Gainsboro;
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Location = new Point(6, 196);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(96, 16);
            textBox7.TabIndex = 12;
            textBox7.TabStop = false;
            textBox7.Text = "Timeout(ms) :";
            textBox7.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Gainsboro;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(6, 51);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(96, 16);
            textBox2.TabIndex = 2;
            textBox2.TabStop = false;
            textBox2.Text = "Baudrates :";
            textBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // cbFlowControl
            // 
            cbFlowControl.FormattingEnabled = true;
            cbFlowControl.Location = new Point(123, 164);
            cbFlowControl.Name = "cbFlowControl";
            cbFlowControl.Size = new Size(121, 23);
            cbFlowControl.TabIndex = 11;
            // 
            // cbBaudrates
            // 
            cbBaudrates.FormattingEnabled = true;
            cbBaudrates.Location = new Point(123, 49);
            cbBaudrates.Name = "cbBaudrates";
            cbBaudrates.Size = new Size(121, 23);
            cbBaudrates.TabIndex = 3;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.Gainsboro;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Location = new Point(6, 167);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(96, 16);
            textBox6.TabIndex = 10;
            textBox6.TabStop = false;
            textBox6.Text = "Flow control :";
            textBox6.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Gainsboro;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(6, 80);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(96, 16);
            textBox3.TabIndex = 4;
            textBox3.TabStop = false;
            textBox3.Text = "Data bits :";
            textBox3.TextAlign = HorizontalAlignment.Right;
            // 
            // cbStopBit
            // 
            cbStopBit.FormattingEnabled = true;
            cbStopBit.Location = new Point(123, 136);
            cbStopBit.Name = "cbStopBit";
            cbStopBit.Size = new Size(121, 23);
            cbStopBit.TabIndex = 9;
            // 
            // cbDataBits
            // 
            cbDataBits.FormattingEnabled = true;
            cbDataBits.Location = new Point(123, 78);
            cbDataBits.Name = "cbDataBits";
            cbDataBits.Size = new Size(121, 23);
            cbDataBits.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Gainsboro;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Location = new Point(6, 138);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(96, 16);
            textBox5.TabIndex = 8;
            textBox5.TabStop = false;
            textBox5.Text = "Stop bit :";
            textBox5.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Gainsboro;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(6, 109);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(96, 16);
            textBox4.TabIndex = 6;
            textBox4.TabStop = false;
            textBox4.Text = "Parity :";
            textBox4.TextAlign = HorizontalAlignment.Right;
            // 
            // cbParity
            // 
            cbParity.FormattingEnabled = true;
            cbParity.Location = new Point(123, 107);
            cbParity.Name = "cbParity";
            cbParity.Size = new Size(121, 23);
            cbParity.TabIndex = 7;
            // 
            // tbSocket
            // 
            tbSocket.BackColor = Color.Gainsboro;
            tbSocket.Controls.Add(groupBox1);
            tbSocket.Controls.Add(rbUdpC);
            tbSocket.Controls.Add(rbUdpS);
            tbSocket.Controls.Add(rbTcpC);
            tbSocket.Controls.Add(rbTcpS);
            tbSocket.Location = new Point(4, 24);
            tbSocket.Name = "tbSocket";
            tbSocket.Padding = new Padding(3);
            tbSocket.Size = new Size(362, 244);
            tbSocket.TabIndex = 1;
            tbSocket.Text = "SocketComm";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox13);
            groupBox1.Controls.Add(textBox12);
            groupBox1.Controls.Add(ckbDomain);
            groupBox1.Controls.Add(ckbBrordcast);
            groupBox1.Controls.Add(textBox11);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox10);
            groupBox1.Controls.Add(textBox9);
            groupBox1.Controls.Add(textBox8);
            groupBox1.Location = new Point(34, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(290, 194);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Network Set";
            // 
            // textBox13
            // 
            textBox13.BackColor = Color.Gainsboro;
            textBox13.BorderStyle = BorderStyle.None;
            textBox13.Location = new Point(6, 160);
            textBox13.Name = "textBox13";
            textBox13.ReadOnly = true;
            textBox13.Size = new Size(96, 16);
            textBox13.TabIndex = 4;
            textBox13.TabStop = false;
            textBox13.Text = "Port number :";
            textBox13.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(108, 157);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(100, 23);
            textBox12.TabIndex = 10;
            textBox12.Text = "5000";
            textBox12.TextAlign = HorizontalAlignment.Right;
            // 
            // ckbDomain
            // 
            ckbDomain.AutoSize = true;
            ckbDomain.Location = new Point(108, 132);
            ckbDomain.Name = "ckbDomain";
            ckbDomain.Size = new Size(124, 19);
            ckbDomain.TabIndex = 9;
            ckbDomain.Text = "Use domain name";
            ckbDomain.UseVisualStyleBackColor = true;
            // 
            // ckbBrordcast
            // 
            ckbBrordcast.AutoSize = true;
            ckbBrordcast.Location = new Point(108, 107);
            ckbBrordcast.Name = "ckbBrordcast";
            ckbBrordcast.Size = new Size(177, 19);
            ckbBrordcast.TabIndex = 8;
            ckbBrordcast.Text = "Brordcast(255.255.255.255)";
            ckbBrordcast.UseVisualStyleBackColor = true;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(108, 78);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(121, 23);
            textBox11.TabIndex = 7;
            textBox11.TextAlign = HorizontalAlignment.Right;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(108, 48);
            maskedTextBox1.Mask = "990.990.990.990";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(121, 23);
            maskedTextBox1.TabIndex = 6;
            maskedTextBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(108, 19);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            // 
            // textBox10
            // 
            textBox10.BackColor = Color.Gainsboro;
            textBox10.BorderStyle = BorderStyle.None;
            textBox10.Location = new Point(6, 81);
            textBox10.Name = "textBox10";
            textBox10.ReadOnly = true;
            textBox10.Size = new Size(96, 16);
            textBox10.TabIndex = 3;
            textBox10.TabStop = false;
            textBox10.Text = "Domain Name :";
            textBox10.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.Gainsboro;
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Location = new Point(6, 51);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(96, 16);
            textBox9.TabIndex = 2;
            textBox9.TabStop = false;
            textBox9.Text = "Remote IP :";
            textBox9.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.Gainsboro;
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Location = new Point(6, 22);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(96, 16);
            textBox8.TabIndex = 1;
            textBox8.TabStop = false;
            textBox8.Text = "Local IP :";
            textBox8.TextAlign = HorizontalAlignment.Right;
            // 
            // rbUdpC
            // 
            rbUdpC.AutoSize = true;
            rbUdpC.Location = new Point(273, 6);
            rbUdpC.Name = "rbUdpC";
            rbUdpC.Size = new Size(84, 19);
            rbUdpC.TabIndex = 3;
            rbUdpC.Text = "UDP Client";
            rbUdpC.UseVisualStyleBackColor = true;
            // 
            // rbUdpS
            // 
            rbUdpS.AutoSize = true;
            rbUdpS.Location = new Point(184, 6);
            rbUdpS.Name = "rbUdpS";
            rbUdpS.Size = new Size(86, 19);
            rbUdpS.TabIndex = 2;
            rbUdpS.Text = "UDP Server";
            rbUdpS.UseVisualStyleBackColor = true;
            // 
            // rbTcpC
            // 
            rbTcpC.AutoSize = true;
            rbTcpC.Location = new Point(95, 6);
            rbTcpC.Name = "rbTcpC";
            rbTcpC.Size = new Size(81, 19);
            rbTcpC.TabIndex = 1;
            rbTcpC.Text = "TCP Client";
            rbTcpC.UseVisualStyleBackColor = true;
            // 
            // rbTcpS
            // 
            rbTcpS.AutoSize = true;
            rbTcpS.Checked = true;
            rbTcpS.Location = new Point(6, 6);
            rbTcpS.Name = "rbTcpS";
            rbTcpS.Size = new Size(83, 19);
            rbTcpS.TabIndex = 0;
            rbTcpS.TabStop = true;
            rbTcpS.Text = "TCP Server";
            rbTcpS.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 291);
            Controls.Add(tabControl1);
            MaximizeBox = false;
            MaximumSize = new Size(400, 330);
            MinimizeBox = false;
            MinimumSize = new Size(400, 330);
            Name = "Form2";
            Text = "Connection setting";
            tabControl1.ResumeLayout(false);
            tbSerial.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tbSocket.ResumeLayout(false);
            tbSocket.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tbSerial;
        private TabPage tbSocket;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox cbPort;
        private ComboBox cbTimeout;
        private TextBox textBox7;
        private ComboBox cbFlowControl;
        private TextBox textBox6;
        private ComboBox cbStopBit;
        private TextBox textBox5;
        private ComboBox cbParity;
        private TextBox textBox4;
        private ComboBox cbDataBits;
        private TextBox textBox3;
        private ComboBox cbBaudrates;
        private RadioButton rbUdpC;
        private RadioButton rbUdpS;
        private RadioButton rbTcpC;
        private RadioButton rbTcpS;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox textBox8;
        private ComboBox comboBox1;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox11;
        private TextBox textBox13;
        private TextBox textBox12;
        private CheckBox ckbDomain;
        private CheckBox ckbBrordcast;
    }
}