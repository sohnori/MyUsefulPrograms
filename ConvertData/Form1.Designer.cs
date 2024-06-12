namespace ConvertData
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
            gbData = new GroupBox();
            rbFloatD = new RadioButton();
            btConvert = new Button();
            rbBinD = new RadioButton();
            rbOctD = new RadioButton();
            rbHexD = new RadioButton();
            rbDecD = new RadioButton();
            rbAsciiD = new RadioButton();
            tbData = new TextBox();
            gbResult = new GroupBox();
            btClearR = new Button();
            rbDecR = new RadioButton();
            ckbOrderStamp = new CheckBox();
            textBox3 = new TextBox();
            ckbSigned = new CheckBox();
            cbUserdefined = new ComboBox();
            rbUserDefinedR = new RadioButton();
            rbBinR = new RadioButton();
            rbOctR = new RadioButton();
            rbHexR = new RadioButton();
            rbDoubleR = new RadioButton();
            rbFloatR = new RadioButton();
            rbLongR = new RadioButton();
            rbIntegerR = new RadioButton();
            rbShortR = new RadioButton();
            rbByteR = new RadioButton();
            rbAsciiR = new RadioButton();
            tbResult = new TextBox();
            ckbEscape = new CheckBox();
            gbData.SuspendLayout();
            gbResult.SuspendLayout();
            SuspendLayout();
            // 
            // gbData
            // 
            gbData.Controls.Add(rbFloatD);
            gbData.Controls.Add(btConvert);
            gbData.Controls.Add(rbBinD);
            gbData.Controls.Add(rbOctD);
            gbData.Controls.Add(rbHexD);
            gbData.Controls.Add(rbDecD);
            gbData.Controls.Add(rbAsciiD);
            gbData.Controls.Add(tbData);
            gbData.Location = new Point(12, 12);
            gbData.Name = "gbData";
            gbData.Size = new Size(429, 84);
            gbData.TabIndex = 0;
            gbData.TabStop = false;
            gbData.Text = "Data";
            // 
            // rbFloatD
            // 
            rbFloatD.AutoSize = true;
            rbFloatD.Location = new Point(269, 51);
            rbFloatD.Name = "rbFloatD";
            rbFloatD.Size = new Size(130, 19);
            rbFloatD.TabIndex = 7;
            rbFloatD.TabStop = true;
            rbFloatD.Text = "Float(HEX, IEEE754)";
            rbFloatD.UseVisualStyleBackColor = true;
            rbFloatD.CheckedChanged += rbFloatD_CheckedChanged;
            // 
            // btConvert
            // 
            btConvert.Location = new Point(348, 21);
            btConvert.Name = "btConvert";
            btConvert.Size = new Size(75, 23);
            btConvert.TabIndex = 1;
            btConvert.Text = "Convert";
            btConvert.UseVisualStyleBackColor = true;
            btConvert.Click += btConvert_Click;
            // 
            // rbBinD
            // 
            rbBinD.AutoSize = true;
            rbBinD.Location = new Point(219, 51);
            rbBinD.Name = "rbBinD";
            rbBinD.Size = new Size(44, 19);
            rbBinD.TabIndex = 6;
            rbBinD.Text = "BIN";
            rbBinD.UseVisualStyleBackColor = true;
            rbBinD.CheckedChanged += rbBinD_CheckedChanged;
            // 
            // rbOctD
            // 
            rbOctD.AutoSize = true;
            rbOctD.Location = new Point(169, 51);
            rbOctD.Name = "rbOctD";
            rbOctD.Size = new Size(48, 19);
            rbOctD.TabIndex = 5;
            rbOctD.Text = "OCT";
            rbOctD.UseVisualStyleBackColor = true;
            rbOctD.CheckedChanged += rbOctD_CheckedChanged;
            // 
            // rbHexD
            // 
            rbHexD.AutoSize = true;
            rbHexD.Location = new Point(120, 51);
            rbHexD.Name = "rbHexD";
            rbHexD.Size = new Size(47, 19);
            rbHexD.TabIndex = 4;
            rbHexD.Text = "HEX";
            rbHexD.UseVisualStyleBackColor = true;
            rbHexD.CheckedChanged += rbHexD_CheckedChanged;
            // 
            // rbDecD
            // 
            rbDecD.AutoSize = true;
            rbDecD.Location = new Point(66, 51);
            rbDecD.Name = "rbDecD";
            rbDecD.Size = new Size(48, 19);
            rbDecD.TabIndex = 3;
            rbDecD.Text = "DEC";
            rbDecD.UseVisualStyleBackColor = true;
            rbDecD.CheckedChanged += rbDecD_CheckedChanged;
            // 
            // rbAsciiD
            // 
            rbAsciiD.AutoSize = true;
            rbAsciiD.Checked = true;
            rbAsciiD.Location = new Point(6, 51);
            rbAsciiD.Name = "rbAsciiD";
            rbAsciiD.Size = new Size(54, 19);
            rbAsciiD.TabIndex = 2;
            rbAsciiD.TabStop = true;
            rbAsciiD.Text = "ASCII";
            rbAsciiD.UseVisualStyleBackColor = true;
            rbAsciiD.CheckedChanged += rbAsciiD_CheckedChanged;
            // 
            // tbData
            // 
            tbData.Location = new Point(6, 22);
            tbData.Name = "tbData";
            tbData.Size = new Size(336, 23);
            tbData.TabIndex = 0;
            // 
            // gbResult
            // 
            gbResult.Controls.Add(ckbEscape);
            gbResult.Controls.Add(btClearR);
            gbResult.Controls.Add(rbDecR);
            gbResult.Controls.Add(ckbOrderStamp);
            gbResult.Controls.Add(textBox3);
            gbResult.Controls.Add(ckbSigned);
            gbResult.Controls.Add(cbUserdefined);
            gbResult.Controls.Add(rbUserDefinedR);
            gbResult.Controls.Add(rbBinR);
            gbResult.Controls.Add(rbOctR);
            gbResult.Controls.Add(rbHexR);
            gbResult.Controls.Add(rbDoubleR);
            gbResult.Controls.Add(rbFloatR);
            gbResult.Controls.Add(rbLongR);
            gbResult.Controls.Add(rbIntegerR);
            gbResult.Controls.Add(rbShortR);
            gbResult.Controls.Add(rbByteR);
            gbResult.Controls.Add(rbAsciiR);
            gbResult.Controls.Add(tbResult);
            gbResult.Location = new Point(12, 102);
            gbResult.Name = "gbResult";
            gbResult.Size = new Size(429, 332);
            gbResult.TabIndex = 1;
            gbResult.TabStop = false;
            gbResult.Text = "Result";
            gbResult.Enter += gbResult_Enter;
            // 
            // btClearR
            // 
            btClearR.Location = new Point(293, 220);
            btClearR.Name = "btClearR";
            btClearR.Size = new Size(130, 23);
            btClearR.TabIndex = 7;
            btClearR.Text = "Clear";
            btClearR.UseVisualStyleBackColor = true;
            btClearR.Click += btClearR_Click;
            // 
            // rbDecR
            // 
            rbDecR.AutoSize = true;
            rbDecR.Enabled = false;
            rbDecR.Location = new Point(66, 251);
            rbDecR.Name = "rbDecR";
            rbDecR.Size = new Size(48, 19);
            rbDecR.TabIndex = 9;
            rbDecR.Text = "DEC";
            rbDecR.UseVisualStyleBackColor = true;
            // 
            // ckbOrderStamp
            // 
            ckbOrderStamp.AutoSize = true;
            ckbOrderStamp.Location = new Point(144, 304);
            ckbOrderStamp.Name = "ckbOrderStamp";
            ckbOrderStamp.Size = new Size(91, 19);
            ckbOrderStamp.TabIndex = 17;
            ckbOrderStamp.Text = "OrderStamp";
            ckbOrderStamp.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(6, 310);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(100, 16);
            textBox3.TabIndex = 16;
            textBox3.TabStop = false;
            textBox3.Text = "Testing......";
            // 
            // ckbSigned
            // 
            ckbSigned.AutoSize = true;
            ckbSigned.Location = new Point(360, 304);
            ckbSigned.Name = "ckbSigned";
            ckbSigned.Size = new Size(63, 19);
            ckbSigned.TabIndex = 19;
            ckbSigned.Text = "Signed";
            ckbSigned.UseVisualStyleBackColor = true;
            // 
            // cbUserdefined
            // 
            cbUserdefined.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUserdefined.FormattingEnabled = true;
            cbUserdefined.Location = new Point(318, 275);
            cbUserdefined.Name = "cbUserdefined";
            cbUserdefined.Size = new Size(105, 23);
            cbUserdefined.TabIndex = 15;
            // 
            // rbUserDefinedR
            // 
            rbUserDefinedR.AutoSize = true;
            rbUserDefinedR.Location = new Point(215, 279);
            rbUserDefinedR.Name = "rbUserDefinedR";
            rbUserDefinedR.Size = new Size(90, 19);
            rbUserDefinedR.TabIndex = 14;
            rbUserDefinedR.Text = "UserDefined";
            rbUserDefinedR.UseVisualStyleBackColor = true;
            // 
            // rbBinR
            // 
            rbBinR.AutoSize = true;
            rbBinR.Location = new Point(219, 251);
            rbBinR.Name = "rbBinR";
            rbBinR.Size = new Size(44, 19);
            rbBinR.TabIndex = 12;
            rbBinR.Text = "BIN";
            rbBinR.UseVisualStyleBackColor = true;
            // 
            // rbOctR
            // 
            rbOctR.AutoSize = true;
            rbOctR.Location = new Point(169, 251);
            rbOctR.Name = "rbOctR";
            rbOctR.Size = new Size(48, 19);
            rbOctR.TabIndex = 11;
            rbOctR.Text = "OCT";
            rbOctR.UseVisualStyleBackColor = true;
            // 
            // rbHexR
            // 
            rbHexR.AutoSize = true;
            rbHexR.Checked = true;
            rbHexR.Location = new Point(120, 251);
            rbHexR.Name = "rbHexR";
            rbHexR.Size = new Size(47, 19);
            rbHexR.TabIndex = 10;
            rbHexR.TabStop = true;
            rbHexR.Text = "HEX";
            rbHexR.UseVisualStyleBackColor = true;
            // 
            // rbDoubleR
            // 
            rbDoubleR.AutoSize = true;
            rbDoubleR.Enabled = false;
            rbDoubleR.Location = new Point(223, 222);
            rbDoubleR.Name = "rbDoubleR";
            rbDoubleR.Size = new Size(64, 19);
            rbDoubleR.TabIndex = 6;
            rbDoubleR.Text = "Double";
            rbDoubleR.UseVisualStyleBackColor = true;
            // 
            // rbFloatR
            // 
            rbFloatR.AutoSize = true;
            rbFloatR.Enabled = false;
            rbFloatR.Location = new Point(269, 251);
            rbFloatR.Name = "rbFloatR";
            rbFloatR.Size = new Size(130, 19);
            rbFloatR.TabIndex = 13;
            rbFloatR.Text = "Float(HEX, IEEE754)";
            rbFloatR.UseVisualStyleBackColor = true;
            // 
            // rbLongR
            // 
            rbLongR.AutoSize = true;
            rbLongR.Enabled = false;
            rbLongR.Location = new Point(165, 222);
            rbLongR.Name = "rbLongR";
            rbLongR.Size = new Size(52, 19);
            rbLongR.TabIndex = 5;
            rbLongR.Text = "Long";
            rbLongR.UseVisualStyleBackColor = true;
            // 
            // rbIntegerR
            // 
            rbIntegerR.AutoSize = true;
            rbIntegerR.Enabled = false;
            rbIntegerR.Location = new Point(120, 222);
            rbIntegerR.Name = "rbIntegerR";
            rbIntegerR.Size = new Size(39, 19);
            rbIntegerR.TabIndex = 4;
            rbIntegerR.Text = "Int";
            rbIntegerR.UseVisualStyleBackColor = true;
            // 
            // rbShortR
            // 
            rbShortR.AutoSize = true;
            rbShortR.Enabled = false;
            rbShortR.Location = new Point(60, 222);
            rbShortR.Name = "rbShortR";
            rbShortR.Size = new Size(54, 19);
            rbShortR.TabIndex = 3;
            rbShortR.Text = "Short";
            rbShortR.UseVisualStyleBackColor = true;
            // 
            // rbByteR
            // 
            rbByteR.AutoSize = true;
            rbByteR.Enabled = false;
            rbByteR.Location = new Point(6, 222);
            rbByteR.Name = "rbByteR";
            rbByteR.Size = new Size(48, 19);
            rbByteR.TabIndex = 2;
            rbByteR.Text = "Byte";
            rbByteR.UseVisualStyleBackColor = true;
            // 
            // rbAsciiR
            // 
            rbAsciiR.AutoSize = true;
            rbAsciiR.Enabled = false;
            rbAsciiR.Location = new Point(6, 251);
            rbAsciiR.Name = "rbAsciiR";
            rbAsciiR.Size = new Size(54, 19);
            rbAsciiR.TabIndex = 8;
            rbAsciiR.Text = "ASCII";
            rbAsciiR.UseVisualStyleBackColor = true;
            // 
            // tbResult
            // 
            tbResult.Location = new Point(6, 22);
            tbResult.MaxLength = 327670;
            tbResult.Multiline = true;
            tbResult.Name = "tbResult";
            tbResult.ReadOnly = true;
            tbResult.ScrollBars = ScrollBars.Both;
            tbResult.Size = new Size(417, 194);
            tbResult.TabIndex = 0;
            // 
            // ckbEscape
            // 
            ckbEscape.AutoSize = true;
            ckbEscape.Location = new Point(241, 304);
            ckbEscape.Name = "ckbEscape";
            ckbEscape.Size = new Size(113, 19);
            ckbEscape.TabIndex = 18;
            ckbEscape.Text = "Escape Seq.처리";
            ckbEscape.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 446);
            Controls.Add(gbResult);
            Controls.Add(gbData);
            KeyPreview = true;
            MaximizeBox = false;
            MaximumSize = new Size(470, 485);
            MinimizeBox = false;
            MinimumSize = new Size(470, 485);
            Name = "Form1";
            Text = "ConvertData";
            KeyDown += ConvertDataForm_KeyDown;
            gbData.ResumeLayout(false);
            gbData.PerformLayout();
            gbResult.ResumeLayout(false);
            gbResult.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbData;
        private GroupBox gbResult;
        private TextBox tbData;
        private RadioButton rbHexD;
        private RadioButton rbDecD;
        private RadioButton rbAsciiD;
        private Button btConvert;
        private RadioButton rbBinD;
        private RadioButton rbOctD;
        private TextBox tbResult;
        private RadioButton rbByteR;
        private RadioButton rbAsciiR;
        private RadioButton rbShortR;
        private RadioButton rbLongR;
        private RadioButton rbIntegerR;
        private RadioButton rbDoubleR;
        private RadioButton rbFloatR;
        private RadioButton rbUserDefinedR;
        private RadioButton rbBinR;
        private RadioButton rbOctR;
        private RadioButton rbHexR;
        private CheckBox ckbSigned;
        private ComboBox cbUserdefined;
        private TextBox textBox3;
        private CheckBox ckbOrderStamp;
        private RadioButton rbFloatD;
        private Button btClearR;
        private RadioButton rbDecR;
        private CheckBox ckbEscape;
    }
}
