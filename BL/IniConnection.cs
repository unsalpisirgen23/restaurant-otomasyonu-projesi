using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace BL
{
  public  class IniConnection
    {
       public static string FileName = "settings.ini";
       public static string Path;

        static IniConnection()
        {
            Path =  System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)+"\\"+ FileName;
            if (!File.Exists(Path))
            {
                File.Create(Path);
            }
        }

        [DllImport("kernel32")]
        static extern int GetPrivateProfileString(string section,string key,string Default,StringBuilder retVal,int size,string FilePath);

        [DllImport("kernel32")]
        static extern long WritePrivateProfileString(string section, string key, string value, string FilePath);

        public static string GetValue(string key,string section=null)
        {
            StringBuilder ret = new StringBuilder();
            GetPrivateProfileString(section, key, "", ret, key.Length, Path);
            return ret.ToString();
        }

        public static void SetValue(string key,string value,string section = null)
        {
            WritePrivateProfileString(section, key, value, Path);
        }

    }


}
