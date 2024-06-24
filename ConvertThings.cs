using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace Sohnori
{
	namespace Useful
	{
        public static class ConvertData
        {
            static ConvertData() {}            
            public static string asciiStrToHexStr(string src)
            {
                byte[] bytes = new byte[src.Length];
                bytes = Encoding.Default.GetBytes(src);
                return BitConverter.ToString(bytes).Replace("-", " ");
            }
            public static string? asciiStrToOctStr(string src)
            { return null; }
            public static string? asciiStrToBinStr(string src)
            { return null; }
        }
    }
};


