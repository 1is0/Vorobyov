using System.Text;
using System.Runtime.InteropServices;

namespace UnmanagedCode
{
    class MachineInfo
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool GlobalMemoryStatusEx(MemoryStatus ms);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern void GetSystemInfo(ref SystemInfo si);

        public static string GetMachineInfo() 
        {
            MemoryStatus ms = new MemoryStatus();
            GlobalMemoryStatusEx(ms);
            ms.ConvertToMB();
            SystemInfo si = new SystemInfo();
            GetSystemInfo(ref si);
            StringBuilder result = new StringBuilder($" {"Memory status:\n",50}");
            result.Append(ms.MemStatus());
            result.Append($" {"CPU status:\n", 50}");
            result.Append(si.SysStatus());
            return result.ToString();
        }
    }
}
