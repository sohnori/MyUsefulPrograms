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
    }
}
