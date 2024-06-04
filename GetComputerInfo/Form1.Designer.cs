namespace GetComputerInfo
{
    partial class GetComputerInfoForm
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            envInfoTextBox = new TextBox();
            envInfoListBox = new ListBox();
            tabPage2 = new TabPage();
            sysInfoTextBox = new TextBox();
            sysInfoListBox = new ListBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(300, 440);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(envInfoTextBox);
            tabPage1.Controls.Add(envInfoListBox);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(292, 412);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Environment";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // envInfoTextBox
            // 
            envInfoTextBox.Location = new Point(-1, 159);
            envInfoTextBox.Multiline = true;
            envInfoTextBox.Name = "envInfoTextBox";
            envInfoTextBox.ReadOnly = true;
            envInfoTextBox.ScrollBars = ScrollBars.Vertical;
            envInfoTextBox.Size = new Size(290, 250);
            envInfoTextBox.TabIndex = 2;
            // 
            // envInfoListBox
            // 
            envInfoListBox.FormattingEnabled = true;
            envInfoListBox.ItemHeight = 15;
            envInfoListBox.Location = new Point(0, 0);
            envInfoListBox.Name = "envInfoListBox";
            envInfoListBox.Size = new Size(290, 154);
            envInfoListBox.TabIndex = 1;
            envInfoListBox.SelectedIndexChanged += envInfoListBox_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(sysInfoTextBox);
            tabPage2.Controls.Add(sysInfoListBox);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(292, 412);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "SystemInfo";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // sysInfoTextBox
            // 
            sysInfoTextBox.Location = new Point(0, 159);
            sysInfoTextBox.Multiline = true;
            sysInfoTextBox.Name = "sysInfoTextBox";
            sysInfoTextBox.ReadOnly = true;
            sysInfoTextBox.ScrollBars = ScrollBars.Vertical;
            sysInfoTextBox.Size = new Size(290, 250);
            sysInfoTextBox.TabIndex = 1;
            // 
            // sysInfoListBox
            // 
            sysInfoListBox.FormattingEnabled = true;
            sysInfoListBox.ItemHeight = 15;
            sysInfoListBox.Location = new Point(0, 0);
            sysInfoListBox.Name = "sysInfoListBox";
            sysInfoListBox.Size = new Size(290, 154);
            sysInfoListBox.TabIndex = 0;
            sysInfoListBox.SelectedIndexChanged += sysInfoListBox_SelectedIndexChanged;
            // 
            // GetComputerInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 441);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "GetComputerInfoForm";
            Text = "GetComputerInfo";
            KeyDown += GetComputerInfoForm_KeyDown;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListBox sysInfoListBox;
        private TextBox sysInfoTextBox;
        private TextBox envInfoTextBox;
        private ListBox envInfoListBox;
    }
}