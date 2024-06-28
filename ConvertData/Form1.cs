using System.Configuration;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Unicode;

namespace ConvertData
{
    public partial class Form1 : Form
    {
        const string UserDefined1 = "UnicodeToHex";
        const string UserDefined2 = "StrToUnicode";
        string[] inputBuff;
        const int INPUT_BUFFER_MAX = 256;
        int inputBuffIndex;        
        int inputBuffPtr;
        public Form1()
        {
            InitializeComponent();
            cbUserdefined.Items.AddRange(new object[] { UserDefined1, UserDefined2, "Test3", "Test4" });
            inputBuff = new string[INPUT_BUFFER_MAX];
            inputBuffIndex = 0;
            inputBuffPtr = 0;
        }
        private void RbsInit()
        {
            rbByteR.Enabled = false;
            rbShortR.Enabled = false;
            rbIntegerR.Enabled = false;
            rbLongR.Enabled = false;
            rbDoubleR.Enabled = false;
            rbAsciiR.Enabled = false;
            rbDecR.Enabled = false;
            rbHexR.Enabled = false;
            rbOctR.Enabled = false;
            rbBinR.Enabled = false;
            rbFloatR.Enabled = false;            
        }
        private void CkbsInit()
        {
            ckbEscape.Enabled = false;
            ckbOrderStamp.Enabled = true;
            ckbEndian.Enabled = false;
            ckbSigned.Enabled = false;
        }
        private void ConvertDataForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                switch (e.KeyCode)
                {
                    case (Keys.D0):
                        this.Location = new Point(0, 0);
                        break;
                    case (Keys.D1):
                        tbData.Focus();
                        break;
                    case (Keys.D9):
                        this.Location = MousePosition;
                        break;
                    case (Keys.Oemtilde):
                        btClearR.PerformClick();
                        break;
                    case (Keys.Enter):
                        btConvert.PerformClick();
                        break;
                    case (Keys.X):
                        this.Dispose();
                        break;
                }
            }
        }
        private void TbData_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    btConvert.PerformClick();
                    break;
                case Keys.Up:
                    if (inputBuffPtr <= 0) inputBuffPtr = inputBuffIndex + 1;
                    tbData.Text = inputBuff[--inputBuffPtr];
                    break;
                case Keys.Down:
                    if (inputBuffPtr > (inputBuffIndex-1)) inputBuffPtr = -1;
                    tbData.Text = inputBuff[++inputBuffPtr];
                    break;

            }
        }
        private void TbData_KeyPress(object sender, KeyPressEventArgs e)
        {
            //int i = 0;
            //if (rbDecD.Checked && !(e.KeyChar >= '0' && e.KeyChar <= '9')) i++;
            //if (rbHexD.Checked && !((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar >= 'a' && e.KeyChar <= 'f') || (e.KeyChar >= 'A' && e.KeyChar <= 'F'))) i++;
            //if (rbOctD.Checked && !(e.KeyChar >= '0' && e.KeyChar <= '8')) i++;
            //if (rbBinD.Checked && !(e.KeyChar >= '0' && e.KeyChar <= '1')) i++;

            //if(i > 0 ) e.Handled = true;
        }
        private void RbAsciiD_CheckedChanged(object sender, EventArgs e)
        {
            this.RbsInit();
            this.CkbsInit();
            rbHexR.Enabled = true;
            rbOctR.Enabled = true;
            rbBinR.Enabled = true;

            rbHexR.Checked = true;
            ckbEscape.Enabled = true;
        }
        private void RbDecD_CheckedChanged(object sender, EventArgs e)
        {
            this.RbsInit();
            this.CkbsInit();
            rbByteR.Enabled = true;
            rbShortR.Enabled = true;
            rbIntegerR.Enabled = true;
            rbLongR.Enabled = true;
            rbDoubleR.Enabled = true;
            rbFloatR.Enabled = true;

            ckbEndian.Enabled = true;
            rbByteR.Checked = true;
        }
        private void RbHexD_CheckedChanged(object sender, EventArgs e)
        {

            this.RbsInit();
            this.CkbsInit();
            rbAsciiR.Enabled = true;
            rbDecR.Enabled = true;
            rbOctR.Enabled = true;
            rbBinR.Enabled = true;

            rbAsciiR.Checked = true;
        }
        private void RbOctD_CheckedChanged(object sender, EventArgs e)
        {
            this.RbsInit();
            this.CkbsInit();
            rbAsciiR.Enabled = true;
            rbHexR.Enabled = true;
            rbBinR.Enabled = true;

            rbAsciiR.Checked = true;
        }
        private void RbBinD_CheckedChanged(object sender, EventArgs e)
        {
            this.RbsInit();
            this.CkbsInit();
            rbAsciiR.Enabled = true;
            rbHexR.Enabled = true;
            rbOctR.Enabled = true;

            rbAsciiR.Checked = true;
        }
        private void RbFloatD_CheckedChanged(object sender, EventArgs e)
        {
            this.RbsInit();
            this.CkbsInit();
            rbDecR.Enabled = true;

            ckbEndian.Enabled = true;
            rbDecR.Checked = true;
        }
        private void RbUserDefinedD_CheckedChanged(Object sender, EventArgs e)
        {

        }
        private void RbsCommonSet(object sender, EventArgs e)
        {
            this.RbsInit();
            this.CkbsInit();
            rbDecR.Enabled = true;
            
            ckbSigned.Enabled = true;
            rbDecR.Checked = true;
        }        
        private void BtClearR_Click(object sender, EventArgs e)
        {
            tbResult.Clear();
        }
        private void BtConvert_Click(object sender, EventArgs e)
        {
            byte[] bytes = new byte[tbData.Text.Length];
            bytes = Encoding.Default.GetBytes(tbData.Text);
            if (ckbOrderStamp.Checked) tbResult.Text += tbOsFore.Text;
            if (rbAsciiD.Checked && rbHexR.Checked) tbResult.Text += ConvertData.ConvertThings.AsciiStrToHexStr(tbData.Text, ckbEscape.Checked);
            else if (rbAsciiD.Checked && rbOctR.Checked) tbResult.Text += ConvertData.ConvertThings.AsciiStrToOctStr(tbData.Text, ckbEscape.Checked);
            else if (rbAsciiD.Checked && rbBinR.Checked) tbResult.Text += ConvertData.ConvertThings.AsciiStrToBinStr(tbData.Text, ckbEscape.Checked);
            else if (rbDecD.Checked && rbByteR.Checked) tbResult.Text += ConvertData.ConvertThings.DecStrToByteStr(tbData.Text);
            else if (rbDecD.Checked && rbShortR.Checked) tbResult.Text += ConvertData.ConvertThings.DecStrToShortStr(tbData.Text);
            else if (rbDecD.Checked && rbIntegerR.Checked) tbResult.Text += ConvertData.ConvertThings.DecStrToInt32Str(tbData.Text);
            else if (rbDecD.Checked && rbLongR.Checked) tbResult.Text += ConvertData.ConvertThings.DecStrToLongStr(tbData.Text);
            else if (rbDecD.Checked && rbDoubleR.Checked) tbResult.Text += ConvertData.ConvertThings.DecStrToDoubleStr(tbData.Text);
            else if (rbDecD.Checked && rbFloatR.Checked) tbResult.Text += ConvertData.ConvertThings.DecStrToFloatStr(tbData.Text, ckbEndian.Checked);
            else if (rbHexD.Checked && rbAsciiR.Checked) tbResult.Text += ConvertData.ConvertThings.HexStrToAsciiStr(tbData.Text);
            else if (rbHexD.Checked && rbDecR.Checked) tbResult.Text += ConvertData.ConvertThings.HexStrToDecStr(tbData.Text);
            else if (rbHexD.Checked && rbOctR.Checked) tbResult.Text += ConvertData.ConvertThings.HexStrToOctStr(tbData.Text);
            else if (rbHexD.Checked && rbBinR.Checked) tbResult.Text += ConvertData.ConvertThings.HexStrToBinStr(tbData.Text);
            else if (rbOctD.Checked && rbAsciiR.Checked) tbResult.Text += ConvertData.ConvertThings.OctStrToAsciiStr(tbData.Text);
            else if (rbOctD.Checked && rbHexR.Checked) tbResult.Text += ConvertData.ConvertThings.OctStrToHexStr(tbData.Text);
            else if (rbOctD.Checked && rbBinR.Checked) tbResult.Text += ConvertData.ConvertThings.OctStrToBinStr(tbData.Text);
            else if (rbBinD.Checked && rbAsciiR.Checked) tbResult.Text += ConvertData.ConvertThings.BinStrToAsciiStr(tbData.Text);
            else if (rbBinD.Checked && rbHexR.Checked) tbResult.Text += ConvertData.ConvertThings.BinStrToHexStr(tbData.Text);
            else if (rbBinD.Checked && rbOctR.Checked) tbResult.Text += ConvertData.ConvertThings.BinStrToOctStr(tbData.Text);
            else if (rbFloatD.Checked && rbDecR.Checked) tbResult.Text += ConvertData.ConvertThings.FloatStrToDecStr(tbData.Text, ckbEndian.Checked);
            else if (rbByteD.Checked && rbDecR.Checked) tbResult.Text += ConvertData.ConvertThings.ByteStrToDecStr(tbData.Text, ckbSigned.Checked);
            else if (rbShortD.Checked && rbDecR.Checked) tbResult.Text += ConvertData.ConvertThings.ShortStrToDecStr(tbData.Text, ckbSigned.Checked);
            else if (rbIntD.Checked && rbDecR.Checked) tbResult.Text += ConvertData.ConvertThings.Int32StrToDecStr(tbData.Text, ckbSigned.Checked);
            else if (rbLongD.Checked && rbDecR.Checked) tbResult.Text += ConvertData.ConvertThings.LongStrToDecStr(tbData.Text, ckbSigned.Checked);
            else if (rbDoubleD.Checked && rbDecR.Checked) tbResult.Text += ConvertData.ConvertThings.DoubleStrToDecStr(tbData.Text, ckbEndian.Checked);
            else if (rbUserDefinedD.Checked && cbUserdefined.Text == UserDefined1) tbResult.Text += ConvertData.ConvertThings.UnicodeToHexStr(tbData.Text);
            else if (rbUserDefinedD.Checked && cbUserdefined.Text == UserDefined2) tbResult.Text += ConvertData.ConvertThings.StrToUnicode(tbData.Text);
            else tbResult.Text += "Empty\n";
            if (ckbOrderStamp.Checked) tbResult.Text += tbOsBack.Text;
            tbResult.Text += "\r\n";
            // 스크롤다운
            tbResult.Select(tbResult.Text.Length - 1, 0);
            tbResult.ScrollToCaret();
            // 스크롤다운 또다른방법
            //tbResult.SelectionStart = tbResult.Text.Length;
            inputBuff[inputBuffIndex++] = tbData.Text;            
            if (inputBuffIndex >= INPUT_BUFFER_MAX) inputBuffIndex = 0;
            inputBuffPtr = inputBuffIndex;
            tbData.Clear();
        }
    }
    public static class ConvertThings
    {
        static ConvertThings() { }        

        public static string AsciiStrToHexStr(string src, bool eSeq = false)
        {            
            string str = src;
            //string str = src.Replace("\\r", "\r").Replace("\\n", "\n");
            if (eSeq)  str = Regex.Unescape(src);
            byte[] bytes = Encoding.Default.GetBytes(str);            
            return BitConverter.ToString(bytes).Replace("-", " ");
        }
        public static string AsciiStrToOctStr(string src, bool eSeq = false)
        {
            string str = src;
            //string str = src.Replace("\\r", "\r").Replace("\\n", "\n");
            if (eSeq) str = Regex.Unescape(src);
            byte[] bytes = Encoding.Default.GetBytes(str);
            string result = "";
            foreach (byte b in bytes)
            {
                StringBuilder sb = new StringBuilder();
                string str2 = Convert.ToString(b, 8);
                sb.Append(str2);
                if (str2.Length < 3)
                {
                    for(int i = 0;i < (3-str2.Length);i++)
                    {                        
                        sb.Insert(0, '0');
                    }
                }
                result = result + sb + " ";
            }
            return result;
        }
        public static string AsciiStrToBinStr(string src, bool eSeq = false)
        {
            string str = src;
            //string str = src.Replace("\\r", "\r").Replace("\\n", "\n");
            if (eSeq) str = Regex.Unescape(src);
            byte[] bytes = Encoding.Default.GetBytes(str);
            string result = "";
            foreach (byte b in bytes)
            {
                StringBuilder sb = new StringBuilder();
                string str2 = Convert.ToString(b, 2);
                sb.Append(str2);
                if (str2.Length < 8)
                {
                    for (int i = 0; i < (8 - str2.Length); i++)
                    {
                        sb.Insert(0, '0');
                    }
                }
                result = result + sb + " ";
            }
            return result;
        }
        public static string DecStrToByteStr(string src)
        {
            string result = string.Empty;
            try
            {
                long val = Convert.ToInt64(src);
                val %= byte.MaxValue;
                StringBuilder sb = new StringBuilder();
                sb.Append(Convert.ToString(val, 16));                
                if (sb.Length >= 2) result = sb.ToString().Substring(sb.Length - 2, 2);
                else if(sb.Length==1)  result = sb.Insert(0, "0").ToString();
                else result = sb.ToString();
            }
            catch (Exception e) { result = e.Message + "\n"; }
            return result;
        }
        public static string DecStrToShortStr(string src)
        {
            string result = string.Empty;
            try
            {
                long val = Convert.ToInt64(src);
                val %= short.MaxValue;
                StringBuilder sb = new StringBuilder();
                sb.Append(Convert.ToString(val, 16));
                if (sb.Length >= 4) result = sb.ToString().Substring(sb.Length - 4, 4);
                else if (sb.Length < 4)
                {
                    int i = 4 - sb.Length;
                    for(int j = 0;j < i;j++) sb.Insert(0, "0");
                    result = sb.ToString();
                }
                else result = sb.ToString();
            }
            catch (Exception e) { result = e.Message + "\n"; }
            return result;
        }
        public static string DecStrToInt32Str(string src)
        {
            string result = string.Empty;
            try
            {
                long val = Convert.ToInt64(src);
                val %= int.MaxValue;
                StringBuilder sb = new StringBuilder();
                sb.Append(Convert.ToString(val, 16));
                if (sb.Length >= 8) result = sb.ToString().Substring(sb.Length - 8, 8);
                else if (sb.Length < 8)
                {
                    int i = 8 - sb.Length;
                    for (int j = 0; j < i; j++) sb.Insert(0, "0");
                    result = sb.ToString();
                }
                else result = sb.ToString();
            }
            catch (Exception e) { result = e.Message + "\n"; }
            return result;
        }
        public static string DecStrToLongStr(string src)
        {
            string result = string.Empty;
            try
            {
                long val = Convert.ToInt64(src);
                val %= long.MaxValue;
                StringBuilder sb = new StringBuilder();
                sb.Append(Convert.ToString(val, 16));
                if (sb.Length >= 16) result = sb.ToString().Substring(sb.Length - 16, 16);
                else if (sb.Length < 16)
                {
                    int i = 16 - sb.Length;
                    for (int j = 0; j < i; j++) sb.Insert(0, "0");
                    result = sb.ToString();
                }
                else result = sb.ToString();
            }
            catch (Exception e) { result = e.Message + "\n"; }
            return result;
        }
        public static string DecStrToDoubleStr(string src)
        {
            string result = string.Empty;
            try
            {
                double val = Convert.ToDouble(src);
                result = BitConverter.ToString(BitConverter.GetBytes(val)).Replace("-", " ");
            }
            catch (Exception e) { result = e.Message + "\n"; }
            return result;
        }
        public static string DecStrToFloatStr(string src, bool reverse=false)
        {
            string result = string.Empty;
            try
            {
                float val = Convert.ToSingle(src);
                byte[] bytes = BitConverter.GetBytes(val);
                if (reverse==true) Array.Reverse(bytes);
                result = BitConverter.ToString(bytes).Replace("-", " ");
            }
            catch (Exception e) { result = e.Message + "\n"; }
            return result;
        }
        public static string HexStrToAsciiStr(string src)
        {
            string str = Convert.ToString(src).Replace(" ", "");
            string retStr = string.Empty;
            try
            {                
                for (int i = 0; i < str.Length; i += 2)
                {
                    string temp = string.Empty;
                    temp = str.Substring(i, 2);
                    long val = Convert.ToInt64(temp, 16);
                    char ascii = Convert.ToChar(val);
                    retStr += ascii;

                }
                return retStr;
            }
            catch (Exception e) { retStr = e.Message + "\n"; }
            return retStr;
        }
        public static string HexStrToDecStr(string src)
        {
            string str = Convert.ToString(src).Replace(" ", "");
            if ((str.Length % 2) == 1) str = str.Substring(0, str.Length - 1);
            string retStr = string.Empty;
            try
            {
                long val = Convert.ToInt64(str, 16);
                // 비슷하지만 다른 표현
                //int val  = int.Parse(str, System.Globalization.NumberStyles.HexNumber);
                retStr = val.ToString();
                return retStr;
            }
            catch (Exception e) { retStr = e.Message + "\n"; }
            return retStr;
        }
        public static string HexStrToOctStr(string src)
        {
            string str = Convert.ToString(src).Replace(" ", "");
            if((str.Length%2)>0) str = str.Substring(0, str.Length-1);
            string result = string.Empty;
            try
            {
                byte[] bytes = Convert.FromHexString(str);
                foreach (byte b in bytes)
                {
                    StringBuilder sb = new StringBuilder();
                    str = Convert.ToString(b, 8);
                    sb.Append(str);
                    if (str.Length < 3)
                    {
                        for (int i = 0; i < (3 - str.Length); i++)
                        {
                            sb.Insert(0, '0');
                        }
                    }
                    result = result + sb + " ";
                }
            }
            catch (Exception e) { result = e.Message + "\n"; }
            return result;   
        }
        public static string HexStrToBinStr(string src)
        {
            string str = Convert.ToString(src).Replace(" ", "");
            if ((str.Length % 2) > 0) str = str.Substring(0, str.Length - 1);
            string result = string.Empty;
            try
            {
                byte[] bytes = Convert.FromHexString(str);
                foreach (byte b in bytes)
                {
                    StringBuilder sb = new StringBuilder();
                    str = Convert.ToString(b, 2);
                    sb.Append(str);
                    if (str.Length < 8)
                    {
                        for (int i = 0; i < (8 - str.Length); i++)
                        {
                            sb.Insert(0, '0');
                        }
                    }
                    //sb.ToString().TrimStart('0');
                    result = result + sb + " ";
                }
            }
            catch (Exception e) { result = e.Message + "\n"; }
            return result;
        }
        public static string OctStrToAsciiStr(string src)
        {
            string result = string.Empty;
            string str = Convert.ToString(src).Replace(" ", "");            
            if ((str.Length % 3) > 0) str = str.Substring(0, str.Length - (str.Length%3));
            try
            {
                for (int i = 0; i < (str.Length / 3); i++)
                {
                    string temp = str.Substring((i * 3), 3);
                    result += Convert.ToString(Convert.ToChar(Convert.ToInt16(temp, 8)));
                }
            }
            catch (Exception e) { result = e.Message + "\n"; }
            return result;
        }
        public static string OctStrToHexStr(string src)
        {
            string result = string.Empty;
            string str = Convert.ToString(src).Replace(" ", "");
            if ((str.Length % 3) > 0) str = str.Substring(0, str.Length - (str.Length % 3));
            try
            {
                for (int i = 0; i < (str.Length / 3); i++)
                {
                    string temp = str.Substring((i * 3), 3);
                    StringBuilder sb = new StringBuilder();
                    temp = Convert.ToInt16(temp, 8).ToString("X");
                    sb.Append(temp);
                    if (temp.Length < 2)
                    {
                        for (int j = 0; j < (2 - temp.Length); j++)
                        {
                            sb.Insert(0, '0');
                        }
                    }
                    result += sb + " ";                    
                }
            }
            catch (Exception e) { result = e.Message + "\n"; }
            return result;
        }
        public static string OctStrToBinStr(string src)
        {
            string result = string.Empty;
            string str = Convert.ToString(src).Replace(" ", "");
            if ((str.Length % 3) > 0) str = str.Substring(0, str.Length - (str.Length % 3));
            try
            {
                for (int i = 0; i < (str.Length / 3); i++)
                {
                    string temp = str.Substring((i * 3), 3);
                    byte b = Convert.ToByte(Convert.ToInt16(temp, 8));
                    StringBuilder sb = new StringBuilder();
                    temp = Convert.ToString(b, 2);
                    sb.Append(temp);
                    if (temp.Length < 8)
                    {
                        for (int j = 0; j < (8 - temp.Length); j++)
                        {
                            sb.Insert(0, '0');
                        }
                    }                    
                    result += sb + " ";                    
                }
            }
            catch (Exception e) { result = e.Message + "\n"; }
            return result;
        }
        public static string BinStrToAsciiStr(string src)
        {
            string result = string.Empty;
            string str = Convert.ToString(src).Replace(" ", "");
            if ((str.Length % 8) > 0) str = str.Substring(0, str.Length - (str.Length % 8));
            try
            {
                for (int i = 0; i < (str.Length / 8); i++)
                {
                    string temp = str.Substring((i * 8), 8);
                    StringBuilder sb = new StringBuilder();
                    sb.Append(Convert.ToString(Convert.ToChar(Convert.ToInt16(temp, 2))));
                    result += sb.ToString();                    
                }
            }
            catch (Exception e) { result = e.Message + "\n"; }
            return result;
        }
        public static string BinStrToHexStr(string src)
        {
            string result = string.Empty;
            string str = Convert.ToString(src).Replace(" ", "");
            if ((str.Length % 8) > 0) str = str.Substring(0, str.Length - (str.Length % 8));
            try
            {
                for (int i = 0; i < (str.Length / 8); i++)
                {
                    string temp = str.Substring((i * 8), 8);
                    StringBuilder sb = new StringBuilder();
                    temp = Convert.ToInt16(temp, 2).ToString("X");
                    sb.Append(temp);
                    if (temp.Length < 2)
                    {
                        for (int j = 0; j < (2 - temp.Length); j++)
                        {
                            sb.Insert(0, '0');
                        }
                    }
                    result += sb + " ";
                }
            }
            catch (Exception e) { result = e.Message + "\n"; }
            return result;
        }
        public static string BinStrToOctStr(string src)
        {
            string result = string.Empty;
            string str = Convert.ToString(src).Replace(" ", "");
            if ((str.Length % 8) > 0) str = str.Substring(0, str.Length - (str.Length % 8));
            try
            {
                for (int i = 0; i < (str.Length / 8); i++)
                {
                    string temp = str.Substring((i * 8), 8);
                    StringBuilder sb = new StringBuilder();
                    temp = Convert.ToString(Convert.ToInt16(temp, 2), 8);
                    sb.Append(temp);
                    if (temp.Length < 3)
                    {
                        for (int j = 0; j < (3 - temp.Length); j++)
                        {
                            sb.Insert(0, '0');
                        }
                    }
                    result += sb + " ";
                }
            }
            catch (Exception e) { result = e.Message + "\n"; }
            return result;
        }    
        public static string FloatStrToDecStr(string src, bool reverse = false)
        {
            try
            {
                string result = string.Empty;
                string str = Convert.ToString(src).Replace(" ", "");                
                byte[] bs = Convert.FromHexString(str[..8]);
                if (reverse) Array.Reverse(bs);
                return Convert.ToString(BitConverter.ToSingle(bs, 0));
            }
            catch (Exception e) { Console.Error.WriteLine(e.Message + "\n"); }
            return string.Empty;
        }
        public static string ByteStrToDecStr(string src, bool signed = false)
        {
            string result = string.Empty;
            try
            {                
                if (signed) result = Convert.ToString(Convert.ToSByte(src[..2], 16));
                else result = Convert.ToString(Convert.ToSByte(src[..2], 16));
            }
            catch (Exception e) { result = e.Message + "\n"; }
            return result;
        }
        public static string ShortStrToDecStr(string src, bool signed = false)
        {
            string result = string.Empty;
            string str = Convert.ToString(src).Replace(" ", "");
            try
            {
                if (signed) result = Convert.ToString(Convert.ToInt16(str[..4], 16));
                else result = Convert.ToString(Convert.ToUInt16(str[..4], 16));
            }
            catch (Exception e) { result = e.Message + "\n"; }
            return result;
        }
        public static string Int32StrToDecStr(string src, bool signed = false)
        {
            string result = string.Empty;
            string str = Convert.ToString(src).Replace(" ", "");
            try
            {
                if (signed) result = Convert.ToString(Convert.ToInt32(str[..8], 16));
                else result = Convert.ToString(Convert.ToUInt32(str[..8], 16));
            }
            catch (Exception e) { result = e.Message + "\n"; }
            return result;
        }
        public static string LongStrToDecStr(string src, bool signed = false)
        {
            string result = string.Empty;
            string str = Convert.ToString(src).Replace(" ", "");
            try
            {
                if (signed) result = Convert.ToString(Convert.ToInt64(str[..16], 16));
                else result = Convert.ToString(Convert.ToUInt64(str[..16], 16));
            }
            catch (Exception e) { result = e.Message + "\n"; }
            return result;
        }
        public static string DoubleStrToDecStr(string src, bool reverse = false)
        {
            string result = string.Empty;
            try
            {                
                string str = Convert.ToString(src).Replace(" ", "");
                byte[] bs = Convert.FromHexString(str[..16]);
                if (reverse) Array.Reverse(bs);
                result = Convert.ToString(BitConverter.ToDouble(bs, 0)); 
            }
            catch (Exception e) { result = e.Message + "\n"; }
            return result;
        }
        public static string UnicodeToHexStr(string src)
        {
            string result = string.Empty;            
            Encoding ascii = Encoding.ASCII;
            Encoding utf8 = Encoding.UTF8;
            Encoding utf16 = Encoding.Unicode;
            Encoding utf32 = Encoding.UTF32;
            string srcStr = Regex.Unescape(src);
            byte[] asciiBytes = ascii.GetBytes(srcStr);
            byte[] utf8Bytes = utf8.GetBytes(srcStr);
            byte[] utf16Bytes = utf16.GetBytes(srcStr);
            byte[] utf32Bytes = utf32.GetBytes(srcStr);

            result = "ASCII : " + BitConverter.ToString(asciiBytes).Replace("-", " ") + "\r\n";
            result += "UTF8 : " + BitConverter.ToString(utf8Bytes).Replace("-", " ") + "\r\n";
            result += "Unicode : " + BitConverter.ToString(utf16Bytes).Replace("-", " ") + "\r\n";
            result += "UTF32 : " + BitConverter.ToString(utf32Bytes).Replace("-", " ") + "\r\n";

            return result;
            
        }
        public static string StrToUnicode(string src)
        {
            string result = string.Empty;
            Encoding ascii = Encoding.ASCII;
            Encoding utf8 = Encoding.UTF8;
            Encoding utf16 = Encoding.Unicode;
            Encoding utf32 = Encoding.UTF32;
            string srcStr = Regex.Unescape(src);
            byte[] asciiBytes = ascii.GetBytes(srcStr);
            byte[] utf8Bytes = utf8.GetBytes(srcStr);
            byte[] utf16Bytes = utf16.GetBytes(srcStr);
            byte[] utf32Bytes = utf32.GetBytes(srcStr);

            result = "ASCII : " + ascii.GetString(asciiBytes) + "\r\n";
            result += "UTF8 : " + utf8.GetString(utf8Bytes) + "\r\n";
            result += "Unicode : " + utf16.GetString(utf16Bytes) + "\r\n";
            result += "UTF32 : " + utf32.GetString(utf32Bytes) + "\r\n";

            return result;
        }
    }
}
