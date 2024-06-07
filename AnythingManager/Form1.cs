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
        private void AnythingManagerForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                switch (e.KeyCode)
                {
                    case (Keys.D0):
                        this.Location = new Point(0, 0);
                        break;
                }
            }
        }

        private void Program1_Click(object sender, EventArgs e)
        {
            try
            {
                string basePath = Environment.CurrentDirectory;
                string relativePath = "..\\..\\..\\..\\GetComputerInfo\\bin\\Debug\\net6.0-windows\\GetComputerInfo.exe";
                string fullPath = Path.GetFullPath(relativePath, basePath);

                if (Proc[0] != null)
                {
                    Proc[0].CloseMainWindow();
                    Proc[0].Close();
                }
                Proc[0] = Process.Start(fullPath);
                //Proc[0] = Process.Start("C:\\Users\\sohno\\source\\repos\\MyUsefulPrograms\\GetComputerInfo\\bin\\Debug\\net6.0-windows\\GetComputerInfo.exe");
            }
            catch (Exception ex) when (ex is Win32Exception || ex is FileNotFoundException)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string basePath = Environment.CurrentDirectory;
                string relativePath = "..\\..\\..\\..\\ConvertData\\bin\\Debug\\net8.0-windows\\ConvertData.exe";
                string fullPath = Path.GetFullPath(relativePath, basePath);

                if (Proc[1] != null)
                {
                    Proc[1].CloseMainWindow();
                    Proc[1].Close();
                }
                Proc[1] = Process.Start(fullPath);                
            }
            catch (Exception ex) when (ex is Win32Exception || ex is FileNotFoundException)
            {
                Console.WriteLine(ex.Message);
            }
        }        

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string basePath = Environment.CurrentDirectory;
                string relativePath = "..\\..\\..\\..\\SerialComm\\bin\\Debug\\net8.0-windows\\SerialComm.exe";
                string fullPath = Path.GetFullPath(relativePath, basePath);

                if (Proc[2] != null)
                {
                    Proc[2].CloseMainWindow();
                    Proc[2].Close();
                }
                Proc[2] = Process.Start(fullPath);                
            }
            catch (Exception ex) when (ex is Win32Exception || ex is FileNotFoundException)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}