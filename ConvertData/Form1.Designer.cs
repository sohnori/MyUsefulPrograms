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
            btConvert = new Button();
            rbOctD = new RadioButton();
            rbBinD = new RadioButton();
            rbHexD = new RadioButton();
            rbDecD = new RadioButton();
            rbAsciiD = new RadioButton();
            textBox1 = new TextBox();
            gbResult = new GroupBox();
            textBox3 = new TextBox();
            ckbUnsigned = new CheckBox();
            cbUserdefined = new ComboBox();
            rbUserdefinedR = new RadioButton();
            rbOctR = new RadioButton();
            rbBinR = new RadioButton();
            rbHexR = new RadioButton();
            rbDoubleR = new RadioButton();
            rbFloatR = new RadioButton();
            rbLongR = new RadioButton();
            rbIntegerR = new RadioButton();
            rbShortR = new RadioButton();
            rbByteR = new RadioButton();
            rbAsciiR = new RadioButton();
            textBox2 = new TextBox();
            gbData.SuspendLayout();
            gbResult.SuspendLayout();
            SuspendLayout();
            // 
            // gbData
            // 
            gbData.Controls.Add(btConvert);
            gbData.Controls.Add(rbOctD);
            gbData.Controls.Add(rbBinD);
            gbData.Controls.Add(rbHexD);
            gbData.Controls.Add(rbDecD);
            gbData.Controls.Add(rbAsciiD);
            gbData.Controls.Add(textBox1);
            gbData.Location = new Point(12, 12);
            gbData.Name = "gbData";
            gbData.Size = new Size(429, 84);
            gbData.TabIndex = 0;
            gbData.TabStop = false;
            gbData.Text = "Data";
            // 
            // btConvert
            // 
            btConvert.Location = new Point(348, 21);
            btConvert.Name = "btConvert";
            btConvert.Size = new Size(75, 23);
            btConvert.TabIndex = 1;
            btConvert.Text = "Convert";
            btConvert.UseVisualStyleBackColor = true;
            // 
            // rbOctD
            // 
            rbOctD.AutoSize = true;
            rbOctD.Location = new Point(223, 51);
            rbOctD.Name = "rbOctD";
            rbOctD.Size = new Size(48, 19);
            rbOctD.TabIndex = 6;
            rbOctD.Text = "OCT";
            rbOctD.UseVisualStyleBackColor = true;
            // 
            // rbBinD
            // 
            rbBinD.AutoSize = true;
            rbBinD.Location = new Point(173, 51);
            rbBinD.Name = "rbBinD";
            rbBinD.Size = new Size(44, 19);
            rbBinD.TabIndex = 5;
            rbBinD.Text = "BIN";
            rbBinD.UseVisualStyleBackColor = true;
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
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(336, 23);
            textBox1.TabIndex = 0;
            // 
            // gbResult
            // 
            gbResult.Controls.Add(textBox3);
            gbResult.Controls.Add(ckbUnsigned);
            gbResult.Controls.Add(cbUserdefined);
            gbResult.Controls.Add(rbUserdefinedR);
            gbResult.Controls.Add(rbOctR);
            gbResult.Controls.Add(rbBinR);
            gbResult.Controls.Add(rbHexR);
            gbResult.Controls.Add(rbDoubleR);
            gbResult.Controls.Add(rbFloatR);
            gbResult.Controls.Add(rbLongR);
            gbResult.Controls.Add(rbIntegerR);
            gbResult.Controls.Add(rbShortR);
            gbResult.Controls.Add(rbByteR);
            gbResult.Controls.Add(rbAsciiR);
            gbResult.Controls.Add(textBox2);
            gbResult.Location = new Point(12, 102);
            gbResult.Name = "gbResult";
            gbResult.Size = new Size(429, 303);
            gbResult.TabIndex = 1;
            gbResult.TabStop = false;
            gbResult.Text = "Result";
            gbResult.Enter += gbResult_Enter;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(6, 277);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(100, 16);
            textBox3.TabIndex = 15;
            textBox3.TabStop = false;
            textBox3.Text = "Testing......";
            // 
            // ckbUnsigned
            // 
            ckbUnsigned.AutoSize = true;
            ckbUnsigned.Location = new Point(339, 276);
            ckbUnsigned.Name = "ckbUnsigned";
            ckbUnsigned.Size = new Size(76, 19);
            ckbUnsigned.TabIndex = 14;
            ckbUnsigned.Text = "Unsigned";
            ckbUnsigned.UseVisualStyleBackColor = true;
            // 
            // cbUserdefined
            // 
            cbUserdefined.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUserdefined.FormattingEnabled = true;
            cbUserdefined.Location = new Point(318, 247);
            cbUserdefined.Name = "cbUserdefined";
            cbUserdefined.Size = new Size(105, 23);
            cbUserdefined.TabIndex = 13;
            // 
            // rbUserdefinedR
            // 
            rbUserdefinedR.AutoSize = true;
            rbUserdefinedR.Location = new Point(224, 251);
            rbUserdefinedR.Name = "rbUserdefinedR";
            rbUserdefinedR.Size = new Size(88, 19);
            rbUserdefinedR.TabIndex = 12;
            rbUserdefinedR.Text = "Userdefined";
            rbUserdefinedR.UseVisualStyleBackColor = true;
            // 
            // rbOctR
            // 
            rbOctR.AutoSize = true;
            rbOctR.Location = new Point(165, 251);
            rbOctR.Name = "rbOctR";
            rbOctR.Size = new Size(48, 19);
            rbOctR.TabIndex = 11;
            rbOctR.Text = "OCT";
            rbOctR.UseVisualStyleBackColor = true;
            // 
            // rbBinR
            // 
            rbBinR.AutoSize = true;
            rbBinR.Location = new Point(119, 251);
            rbBinR.Name = "rbBinR";
            rbBinR.Size = new Size(44, 19);
            rbBinR.TabIndex = 10;
            rbBinR.Text = "BIN";
            rbBinR.UseVisualStyleBackColor = true;
            // 
            // rbHexR
            // 
            rbHexR.AutoSize = true;
            rbHexR.Location = new Point(66, 251);
            rbHexR.Name = "rbHexR";
            rbHexR.Size = new Size(47, 19);
            rbHexR.TabIndex = 9;
            rbHexR.Text = "HEX";
            rbHexR.UseVisualStyleBackColor = true;
            // 
            // rbDoubleR
            // 
            rbDoubleR.AutoSize = true;
            rbDoubleR.Location = new Point(359, 222);
            rbDoubleR.Name = "rbDoubleR";
            rbDoubleR.Size = new Size(64, 19);
            rbDoubleR.TabIndex = 7;
            rbDoubleR.Text = "Double";
            rbDoubleR.UseVisualStyleBackColor = true;
            // 
            // rbFloatR
            // 
            rbFloatR.AutoSize = true;
            rbFloatR.Location = new Point(223, 222);
            rbFloatR.Name = "rbFloatR";
            rbFloatR.Size = new Size(130, 19);
            rbFloatR.TabIndex = 6;
            rbFloatR.Text = "Float(HEX, IEEE754)";
            rbFloatR.UseVisualStyleBackColor = true;
            // 
            // rbLongR
            // 
            rbLongR.AutoSize = true;
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
            rbAsciiR.Checked = true;
            rbAsciiR.Location = new Point(6, 251);
            rbAsciiR.Name = "rbAsciiR";
            rbAsciiR.Size = new Size(54, 19);
            rbAsciiR.TabIndex = 8;
            rbAsciiR.TabStop = true;
            rbAsciiR.Text = "ASCII";
            rbAsciiR.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 22);
            textBox2.MaxLength = 327670;
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(417, 194);
            textBox2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 417);
            Controls.Add(gbResult);
            Controls.Add(gbData);
            MaximizeBox = false;
            MaximumSize = new Size(470, 456);
            MinimizeBox = false;
            MinimumSize = new Size(470, 456);
            Name = "Form1";
            Text = "ConvertData";
            gbData.ResumeLayout(false);
            gbData.PerformLayout();
            gbResult.ResumeLayout(false);
            gbResult.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbData;
        private GroupBox gbResult;
        private TextBox textBox1;
        private RadioButton rbHexD;
        private RadioButton rbDecD;
        private RadioButton rbAsciiD;
        private Button btConvert;
        private RadioButton rbOctD;
        private RadioButton rbBinD;
        private TextBox textBox2;
        private RadioButton rbByteR;
        private RadioButton rbAsciiR;
        private RadioButton rbShortR;
        private RadioButton rbLongR;
        private RadioButton rbIntegerR;
        private RadioButton rbDoubleR;
        private RadioButton rbFloatR;
        private RadioButton rbUserdefinedR;
        private RadioButton rbOctR;
        private RadioButton rbBinR;
        private RadioButton rbHexR;
        private CheckBox ckbUnsigned;
        private ComboBox cbUserdefined;
        private TextBox textBox3;
    }
}
