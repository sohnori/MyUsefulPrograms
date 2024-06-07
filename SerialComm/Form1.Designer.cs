namespace SerialComm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btConn = new Button();
            tbState = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            rtbPrint = new RichTextBox();
            rbHexP = new RadioButton();
            rbAsciiP = new RadioButton();
            gbPrint = new GroupBox();
            ckbTimestamp = new CheckBox();
            btClear = new Button();
            btSave = new Button();
            ckbReceive = new CheckBox();
            ckbSend = new CheckBox();
            gbSender = new GroupBox();
            btMacro = new Button();
            ckbChecksum = new CheckBox();
            ckbEscapeSeq = new CheckBox();
            rbAsciiS = new RadioButton();
            rbHexS = new RadioButton();
            btSend = new Button();
            tbSender = new TextBox();
            gbChecksum = new GroupBox();
            btChecksum = new Button();
            textBox1 = new TextBox();
            cbChecksum = new ComboBox();
            rbUserDefine = new RadioButton();
            rbCRC32 = new RadioButton();
            rbCrc16 = new RadioButton();
            rbCrc8 = new RadioButton();
            tbTime = new TextBox();
            tbInfo = new TextBox();
            gbPrint.SuspendLayout();
            gbSender.SuspendLayout();
            gbChecksum.SuspendLayout();
            SuspendLayout();
            // 
            // btConn
            // 
            btConn.Location = new Point(12, 12);
            btConn.Name = "btConn";
            btConn.Size = new Size(75, 23);
            btConn.TabIndex = 0;
            btConn.Text = "CONNECT";
            btConn.UseVisualStyleBackColor = true;
            btConn.Click += btConn_Click;
            // 
            // tbState
            // 
            tbState.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbState.BackColor = Color.Silver;
            tbState.Location = new Point(93, 12);
            tbState.Name = "tbState";
            tbState.ReadOnly = true;
            tbState.Size = new Size(679, 23);
            tbState.TabIndex = 1;
            tbState.Text = "None";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // rtbPrint
            // 
            rtbPrint.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbPrint.Location = new Point(12, 41);
            rtbPrint.Name = "rtbPrint";
            rtbPrint.ReadOnly = true;
            rtbPrint.Size = new Size(760, 173);
            rtbPrint.TabIndex = 2;
            rtbPrint.Text = "";
            // 
            // rbHexP
            // 
            rbHexP.AutoSize = true;
            rbHexP.Checked = true;
            rbHexP.Location = new Point(6, 22);
            rbHexP.Name = "rbHexP";
            rbHexP.Size = new Size(47, 19);
            rbHexP.TabIndex = 0;
            rbHexP.TabStop = true;
            rbHexP.Text = "HEX";
            rbHexP.UseVisualStyleBackColor = true;
            // 
            // rbAsciiP
            // 
            rbAsciiP.AutoSize = true;
            rbAsciiP.Location = new Point(59, 22);
            rbAsciiP.Name = "rbAsciiP";
            rbAsciiP.Size = new Size(54, 19);
            rbAsciiP.TabIndex = 1;
            rbAsciiP.Text = "ASCII";
            rbAsciiP.UseVisualStyleBackColor = true;
            // 
            // gbPrint
            // 
            gbPrint.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbPrint.Controls.Add(ckbTimestamp);
            gbPrint.Controls.Add(btClear);
            gbPrint.Controls.Add(btSave);
            gbPrint.Controls.Add(ckbReceive);
            gbPrint.Controls.Add(ckbSend);
            gbPrint.Controls.Add(rbHexP);
            gbPrint.Controls.Add(rbAsciiP);
            gbPrint.Location = new Point(12, 220);
            gbPrint.Name = "gbPrint";
            gbPrint.Size = new Size(760, 50);
            gbPrint.TabIndex = 3;
            gbPrint.TabStop = false;
            gbPrint.Text = "PRINT";
            // 
            // ckbTimestamp
            // 
            ckbTimestamp.AutoSize = true;
            ckbTimestamp.Location = new Point(250, 22);
            ckbTimestamp.Name = "ckbTimestamp";
            ckbTimestamp.Size = new Size(87, 19);
            ckbTimestamp.TabIndex = 4;
            ckbTimestamp.Text = "TimeStamp";
            ckbTimestamp.UseVisualStyleBackColor = true;
            // 
            // btClear
            // 
            btClear.Anchor = AnchorStyles.Right;
            btClear.Location = new Point(679, 17);
            btClear.Name = "btClear";
            btClear.Size = new Size(75, 23);
            btClear.TabIndex = 6;
            btClear.Text = "Clear";
            btClear.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            btSave.Anchor = AnchorStyles.Right;
            btSave.Location = new Point(598, 17);
            btSave.Name = "btSave";
            btSave.Size = new Size(75, 23);
            btSave.TabIndex = 5;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            // 
            // ckbReceive
            // 
            ckbReceive.AutoSize = true;
            ckbReceive.Checked = true;
            ckbReceive.CheckState = CheckState.Checked;
            ckbReceive.Location = new Point(178, 22);
            ckbReceive.Name = "ckbReceive";
            ckbReceive.Size = new Size(66, 19);
            ckbReceive.TabIndex = 3;
            ckbReceive.Text = "Receive";
            ckbReceive.UseVisualStyleBackColor = true;
            // 
            // ckbSend
            // 
            ckbSend.AutoSize = true;
            ckbSend.Checked = true;
            ckbSend.CheckState = CheckState.Checked;
            ckbSend.Location = new Point(119, 22);
            ckbSend.Name = "ckbSend";
            ckbSend.Size = new Size(53, 19);
            ckbSend.TabIndex = 2;
            ckbSend.Text = "Send";
            ckbSend.UseVisualStyleBackColor = true;
            // 
            // gbSender
            // 
            gbSender.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbSender.Controls.Add(btMacro);
            gbSender.Controls.Add(ckbChecksum);
            gbSender.Controls.Add(ckbEscapeSeq);
            gbSender.Controls.Add(rbAsciiS);
            gbSender.Controls.Add(rbHexS);
            gbSender.Controls.Add(btSend);
            gbSender.Controls.Add(tbSender);
            gbSender.Location = new Point(12, 276);
            gbSender.Name = "gbSender";
            gbSender.Size = new Size(760, 73);
            gbSender.TabIndex = 4;
            gbSender.TabStop = false;
            gbSender.Text = "SENDER";
            // 
            // btMacro
            // 
            btMacro.Anchor = AnchorStyles.Right;
            btMacro.Location = new Point(679, 47);
            btMacro.Name = "btMacro";
            btMacro.Size = new Size(75, 23);
            btMacro.TabIndex = 7;
            btMacro.Text = "Macro";
            btMacro.UseVisualStyleBackColor = true;
            // 
            // ckbChecksum
            // 
            ckbChecksum.AutoSize = true;
            ckbChecksum.Location = new Point(258, 51);
            ckbChecksum.Name = "ckbChecksum";
            ckbChecksum.Size = new Size(112, 19);
            ckbChecksum.TabIndex = 6;
            ckbChecksum.Text = "Auto Checksum";
            ckbChecksum.UseVisualStyleBackColor = true;
            ckbChecksum.CheckedChanged += ckbChecksum_CheckedChanged;
            // 
            // ckbEscapeSeq
            // 
            ckbEscapeSeq.AutoSize = true;
            ckbEscapeSeq.Location = new Point(119, 51);
            ckbEscapeSeq.Name = "ckbEscapeSeq";
            ckbEscapeSeq.Size = new Size(133, 19);
            ckbEscapeSeq.TabIndex = 5;
            ckbEscapeSeq.Text = "Process Escape Seq.";
            ckbEscapeSeq.UseVisualStyleBackColor = true;
            // 
            // rbAsciiS
            // 
            rbAsciiS.AutoSize = true;
            rbAsciiS.Location = new Point(59, 51);
            rbAsciiS.Name = "rbAsciiS";
            rbAsciiS.Size = new Size(54, 19);
            rbAsciiS.TabIndex = 3;
            rbAsciiS.Text = "ASCII";
            rbAsciiS.UseVisualStyleBackColor = true;
            // 
            // rbHexS
            // 
            rbHexS.AutoSize = true;
            rbHexS.Checked = true;
            rbHexS.Location = new Point(6, 51);
            rbHexS.Name = "rbHexS";
            rbHexS.Size = new Size(47, 19);
            rbHexS.TabIndex = 3;
            rbHexS.TabStop = true;
            rbHexS.Text = "HEX";
            rbHexS.UseVisualStyleBackColor = true;
            // 
            // btSend
            // 
            btSend.Anchor = AnchorStyles.Right;
            btSend.Location = new Point(679, 22);
            btSend.Name = "btSend";
            btSend.Size = new Size(75, 23);
            btSend.TabIndex = 1;
            btSend.Text = "Send";
            btSend.UseVisualStyleBackColor = true;
            // 
            // tbSender
            // 
            tbSender.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbSender.Location = new Point(6, 22);
            tbSender.Name = "tbSender";
            tbSender.Size = new Size(667, 23);
            tbSender.TabIndex = 0;
            // 
            // gbChecksum
            // 
            gbChecksum.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbChecksum.Controls.Add(btChecksum);
            gbChecksum.Controls.Add(textBox1);
            gbChecksum.Controls.Add(cbChecksum);
            gbChecksum.Controls.Add(rbUserDefine);
            gbChecksum.Controls.Add(rbCRC32);
            gbChecksum.Controls.Add(rbCrc16);
            gbChecksum.Controls.Add(rbCrc8);
            gbChecksum.Location = new Point(12, 352);
            gbChecksum.Name = "gbChecksum";
            gbChecksum.Size = new Size(760, 42);
            gbChecksum.TabIndex = 5;
            gbChecksum.TabStop = false;
            gbChecksum.Visible = false;
            // 
            // btChecksum
            // 
            btChecksum.Location = new Point(517, 15);
            btChecksum.Name = "btChecksum";
            btChecksum.Size = new Size(75, 23);
            btChecksum.TabIndex = 6;
            btChecksum.Text = "Create";
            btChecksum.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(433, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(75, 23);
            textBox1.TabIndex = 5;
            // 
            // cbChecksum
            // 
            cbChecksum.DropDownStyle = ComboBoxStyle.DropDownList;
            cbChecksum.FormattingEnabled = true;
            cbChecksum.Location = new Point(293, 13);
            cbChecksum.Name = "cbChecksum";
            cbChecksum.Size = new Size(134, 23);
            cbChecksum.TabIndex = 4;
            // 
            // rbUserDefine
            // 
            rbUserDefine.AutoSize = true;
            rbUserDefine.Location = new Point(202, 19);
            rbUserDefine.Name = "rbUserDefine";
            rbUserDefine.Size = new Size(85, 19);
            rbUserDefine.TabIndex = 3;
            rbUserDefine.Text = "사용자정의";
            rbUserDefine.UseVisualStyleBackColor = true;
            // 
            // rbCRC32
            // 
            rbCRC32.AutoSize = true;
            rbCRC32.Location = new Point(134, 19);
            rbCRC32.Name = "rbCRC32";
            rbCRC32.Size = new Size(62, 19);
            rbCRC32.TabIndex = 2;
            rbCRC32.Text = "CRC32";
            rbCRC32.UseVisualStyleBackColor = true;
            // 
            // rbCrc16
            // 
            rbCrc16.AutoSize = true;
            rbCrc16.Location = new Point(66, 19);
            rbCrc16.Name = "rbCrc16";
            rbCrc16.Size = new Size(62, 19);
            rbCrc16.TabIndex = 1;
            rbCrc16.Text = "CRC16";
            rbCrc16.UseVisualStyleBackColor = true;
            // 
            // rbCrc8
            // 
            rbCrc8.AutoSize = true;
            rbCrc8.Checked = true;
            rbCrc8.Location = new Point(5, 19);
            rbCrc8.Name = "rbCrc8";
            rbCrc8.Size = new Size(55, 19);
            rbCrc8.TabIndex = 0;
            rbCrc8.TabStop = true;
            rbCrc8.Text = "CRC8";
            rbCrc8.UseVisualStyleBackColor = true;
            // 
            // tbTime
            // 
            tbTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tbTime.BackColor = SystemColors.Control;
            tbTime.BorderStyle = BorderStyle.None;
            tbTime.Location = new Point(529, 400);
            tbTime.Name = "tbTime";
            tbTime.ReadOnly = true;
            tbTime.Size = new Size(243, 16);
            tbTime.TabIndex = 7;
            tbTime.TabStop = false;
            tbTime.Text = "2024-03-19 14:13:33";
            tbTime.TextAlign = HorizontalAlignment.Right;
            // 
            // tbInfo
            // 
            tbInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tbInfo.BorderStyle = BorderStyle.None;
            tbInfo.Location = new Point(12, 400);
            tbInfo.Name = "tbInfo";
            tbInfo.ReadOnly = true;
            tbInfo.Size = new Size(427, 16);
            tbInfo.TabIndex = 6;
            tbInfo.TabStop = false;
            tbInfo.Text = "Testing......";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 428);
            Controls.Add(tbInfo);
            Controls.Add(tbTime);
            Controls.Add(gbChecksum);
            Controls.Add(gbSender);
            Controls.Add(gbPrint);
            Controls.Add(rtbPrint);
            Controls.Add(tbState);
            Controls.Add(btConn);
            KeyPreview = true;
            MinimumSize = new Size(600, 300);
            Name = "Form1";
            Text = "SerialComm";
            KeyDown += SerialCommForm_KeyDown;
            Load += Form1_Load;
            gbPrint.ResumeLayout(false);
            gbPrint.PerformLayout();
            gbSender.ResumeLayout(false);
            gbSender.PerformLayout();
            gbChecksum.ResumeLayout(false);
            gbChecksum.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btConn;
        private TextBox tbState;
        private System.Windows.Forms.Timer timer1;
        private RichTextBox rtbPrint;
        private RadioButton rbHexP;
        private RadioButton rbAsciiP;
        private GroupBox gbPrint;
        private CheckBox ckbSend;
        private CheckBox ckbReceive;
        private Button btClear;
        private Button btSave;
        private CheckBox ckbTimestamp;
        private GroupBox gbSender;
        private Button btSend;
        private TextBox tbSender;
        private CheckBox ckbEscapeSeq;
        private RadioButton rbAsciiS;
        private RadioButton rbHexS;
        private CheckBox ckbChecksum;
        private GroupBox gbChecksum;
        private RadioButton rbCrc16;
        private RadioButton rbCrc8;
        private RadioButton rbUserDefine;
        private RadioButton rbCRC32;
        private ComboBox cbChecksum;
        private Button btChecksum;
        private TextBox textBox1;
        private TextBox tbTime;
        private TextBox tbInfo;
        private Button btMacro;
    }
}
