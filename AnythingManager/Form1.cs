using Microsoft.VisualBasic.Devices;
using System.ComponentModel;
using System.Diagnostics;
using static System.Windows.Forms.AxHost;

namespace AnythingManager
{
    public partial class AnythingManagerForm : Form
    {
        private Process[] Proc;
        public AnythingManagerForm()
        {
            InitializeComponent();
            Proc = new Process[12];
        }

        private void Program1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Proc[0] != null)
                {
                    Proc[0].CloseMainWindow();
                    Proc[0].Close();
                }
                Proc[0] = Process.Start("C:\\Users\\sohno\\source\\repos\\MyUsefulPrograms\\GetComputerInfo\\bin\\Debug\\net6.0-windows\\GetComputerInfo.exe");
            }
            catch (Exception ex) when (ex is Win32Exception || ex is FileNotFoundException)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void AnythingManagerForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Modifiers == Keys.Control)
            {
                switch (e.KeyCode)
                {
                    case (Keys.D0):
                        this.Location = new Point(0, 0);
                        break;
                }
            }
        }

    }
}