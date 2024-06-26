using System.Globalization;

namespace SerialComm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void SerialCommForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.D0:
                        this.Location = new Point(0, 0);
                        break;
                }
            }
        }
        private void btConn_Click(object sender, EventArgs e)
        {
            SerialComm.Form2 dlgConn = new SerialComm.Form2();
            dlgConn.ShowDialog();
            dlgConn.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            tbTime.Text = dt.ToString("F", DateTimeFormatInfo.InvariantInfo);

        }

        private void ckbChecksum_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbChecksum.Checked) gbChecksum.Visible = true;
            else gbChecksum.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
