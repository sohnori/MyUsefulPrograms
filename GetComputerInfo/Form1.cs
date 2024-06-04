using System.Collections;
using System.Reflection;
using System.Text;

namespace GetComputerInfo
{
    public partial class GetComputerInfoForm : Form
    {
        public GetComputerInfoForm()
        {
            InitializeComponent();
            Type t = typeof(Environment);
            PropertyInfo[] pi = t.GetProperties();
            for (int i = 0; i < pi.Length; i++) envInfoListBox.Items.Add(pi[i].Name);
            envInfoListBox.Items.Add("CmdLineArgs");
            envInfoListBox.Items.Add("SystemDrive, SystemRoot");
            envInfoListBox.Items.Add("TempDirectory");
            envInfoListBox.Items.Add("EnvVars");
            envInfoListBox.Items.Add("SpecialFolderPath");
            envInfoListBox.Items.Add("LogicalDrives");

            t = typeof(System.Windows.Forms.SystemInformation);
            pi = t.GetProperties();
            for (int i = 0; i < pi.Length; i++) sysInfoListBox.Items.Add(pi[i].Name);
            sysInfoTextBox.Text = "The SystemInformation class has " + pi.Length.ToString() + " properties.\r\n";

        }

        private void sysInfoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sysInfoListBox.SelectedIndex == -1) return;
            string propname = sysInfoListBox.Text;
            if (propname == "PowerStatus")
            {
                sysInfoTextBox.Text = "\r\nThe value of the PowerStatus property is: ";
                Type t = typeof(System.Windows.Forms.PowerStatus);
                PropertyInfo[] pi = t.GetProperties();
                for (int i = 0; i < pi.Length; i++)
                {
                    object? propval = pi[i].GetValue(SystemInformation.PowerStatus, null);
                    sysInfoTextBox.Text += "\r\n    PowerStatus." + pi[i].Name + " is: " + propval?.ToString();

                }
            }
            else
            {
                sysInfoTextBox.Text = "\r\nThe value of the " + propname + " property is: ";
                Type t = typeof(System.Windows.Forms.SystemInformation);
                PropertyInfo[] pi = t.GetProperties();
                PropertyInfo? prop = null;
                for (int i = 0; i < pi.Length; i++) if (pi[i].Name == propname) { prop = pi[i]; break; }
                object? propval = prop?.GetValue(null, null);
                sysInfoTextBox.Text += propval?.ToString();

            }
        }

        private void envInfoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (envInfoListBox.SelectedIndex == -1) return;
            string propname = envInfoListBox.Text;
            envInfoTextBox.Text = "\r\nThe value of the " + propname + " property is: ";
            if (propname == "CmdLineArgs")
            {
                string[] args = Environment.GetCommandLineArgs();
                envInfoTextBox.Text += String.Join(", ", args);
            }
            else if (propname == "SystemDrive, SystemRoot")
            {
                string query = "*SystemDrive_%SystemDrive%, SystemRoot_%SystemRoot%";
                envInfoTextBox.Text += Environment.ExpandEnvironmentVariables(query);
            }
            else if (propname == "TempDirectory") envInfoTextBox.Text += Environment.GetEnvironmentVariable("TEMP");
            else if (propname == "EnvVars")
            {
                IDictionary envVar = Environment.GetEnvironmentVariables();
                int cnt = 1;
                foreach (DictionaryEntry de in envVar)
                {
                    envInfoTextBox.Text += string.Format("  {0}_{1} = {2}", cnt, de.Key, de.Value);
                    cnt++;
                }
            }
            else if (propname == "SpecialFolderPath")
            {
                envInfoTextBox.Text += "System_" + Environment.SpecialFolder.System + ", " + "Favorites_" + Environment.GetFolderPath(Environment.SpecialFolder.Favorites);
            }

            else if (propname == "LogicalDrives")
            {
                string[] drives = Environment.GetLogicalDrives();
                envInfoTextBox.Text += String.Join(", ", drives);
            }
            else
            {
                Type t = typeof(Environment);
                PropertyInfo[] pi = t.GetProperties();
                PropertyInfo? prop = null;
                for (int i = 0; i < pi.Length; i++) if (pi[i].Name == propname) { prop = pi[i]; break; }
                object? propval = prop?.GetValue(null, null);
                envInfoTextBox.Text += propval?.ToString();
            }
        }

        private void GetComputerInfoForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Modifiers == Keys.Control)
            {
                switch(e.KeyCode)
                {
                    case Keys.D0:
                        this.Location = new Point(0, 0);
                        break;
                }
            }
        }
    }
}