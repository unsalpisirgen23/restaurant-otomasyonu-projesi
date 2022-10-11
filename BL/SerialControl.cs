using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class SerialControl
    {
        public SerialControl()
        {
            ManagementObjectSearcher s = new ManagementObjectSearcher("Select * from Win32_PhysicalMedia");

            var r = s.Get();
            string sn = "";
            foreach (var item in r)
            {
                sn = item["SerialNumber"].ToString();
                break;
            }

        }
    }
}
