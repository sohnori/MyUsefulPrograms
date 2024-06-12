namespace ConvertData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConvertDataForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D0:
                    this.Location = new Point(0, 0);
                    break;
            }
        }

        private void gbResult_Enter(object sender, EventArgs e)
        {

        }
        private void rbAsciiD_CheckedChanged(object sender, EventArgs e)
        {
            rbByteR.Enabled = false;
            rbShortR.Enabled = false;
            rbIntegerR.Enabled = false;
            rbLongR.Enabled = false;
            rbDoubleR.Enabled = false;
            rbAsciiR.Enabled = false;
            rbDecR.Enabled = false;
            rbHexR.Enabled = true;
            rbOctR.Enabled = true;
            rbBinR.Enabled = true;
            rbFloatR.Enabled = false;

            rbHexR.Checked = true;
        }

        private void rbDecD_CheckedChanged(object sender, EventArgs e)
        {
            rbByteR.Enabled = true;
            rbShortR.Enabled = true;
            rbIntegerR.Enabled = true;
            rbLongR.Enabled = true;
            rbDoubleR.Enabled = true;
            rbAsciiR.Enabled = false;
            rbDecR.Enabled = false;
            rbHexR.Enabled = true;
            rbOctR.Enabled = true;
            rbBinR.Enabled = true;
            rbFloatR.Enabled = true;

            rbByteR.Checked = true;
        }

        private void rbHexD_CheckedChanged(object sender, EventArgs e)
        {
            rbByteR.Enabled = false;
            rbShortR.Enabled = false;
            rbIntegerR.Enabled = false;
            rbLongR.Enabled = false;
            rbDoubleR.Enabled = false;
            rbAsciiR.Enabled = true;
            rbDecR.Enabled = false;
            rbHexR.Enabled = false;
            rbOctR.Enabled = true;
            rbBinR.Enabled = true;
            rbFloatR.Enabled = false;

            rbAsciiR.Checked = true;
        }

        private void rbOctD_CheckedChanged(object sender, EventArgs e)
        {
            rbByteR.Enabled = false;
            rbShortR.Enabled = false;
            rbIntegerR.Enabled = false;
            rbLongR.Enabled = false;
            rbDoubleR.Enabled = false;
            rbAsciiR.Enabled = true;
            rbDecR.Enabled = false;
            rbHexR.Enabled = true;
            rbOctR.Enabled = false;
            rbBinR.Enabled = true;
            rbFloatR.Enabled = false;

            rbAsciiR.Checked = true;
        }

        private void rbBinD_CheckedChanged(object sender, EventArgs e)
        {
            rbByteR.Enabled = false;
            rbShortR.Enabled = false;
            rbIntegerR.Enabled = false;
            rbLongR.Enabled = false;
            rbDoubleR.Enabled = false;
            rbAsciiR.Enabled = true;
            rbDecR.Enabled = false;
            rbHexR.Enabled = true;
            rbOctR.Enabled = true;
            rbBinR.Enabled = false;
            rbFloatR.Enabled = false;

            rbAsciiR.Checked = true;
        }

        private void rbFloatD_CheckedChanged(object sender, EventArgs e)
        {
            rbByteR.Enabled = false;
            rbShortR.Enabled = false;
            rbIntegerR.Enabled = false;
            rbLongR.Enabled = false;
            rbDoubleR.Enabled = false;
            rbAsciiR.Enabled = false;
            rbDecR.Enabled = true;
            rbHexR.Enabled = false;
            rbOctR.Enabled = true;
            rbBinR.Enabled = true;
            rbFloatR.Enabled = false;

            rbDecR.Checked = true;
        }

        private void btClearR_Click(object sender, EventArgs e)
        {
            tbResult.Clear();
        }

        private void btConvert_Click(object sender, EventArgs e)
        {
            
        }
    }
}
