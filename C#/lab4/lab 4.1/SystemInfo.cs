using System;
using System.Runtime.InteropServices;
using System.Text;

namespace UnmanagedCode
{
    [StructLayout(LayoutKind.Sequential)]
    struct SystemInfo 
    {
        ushort wProcessorArchitecture;
        ushort wReserved;
        uint dwPageSize;
        IntPtr lpMinimumApplicationAdress;
        IntPtr lpMaximumApplicationAdress;
        IntPtr dwActiveProcessorMask;
        uint dwNumberOfProcessors;
        uint dwProcessorType;
        uint dwAllocationGranuality;
        ushort wProcessorLevel;
        ushort wProcessorRevision;

        public string SysStatus() 
        {
            StringBuilder status = new StringBuilder();
            status.Append($"Processor architecture: ");
            switch (wProcessorArchitecture)
            { 
                case 0: status.Append($"x86\n");
                    break;
                case 5:
                    status.Append($"ARM\n");
                    break;
                case 6:
                    status.Append($"Intel Itanium-based\n");
                    break;
                case 9:
                    status.Append($"x64 (Intel or AMD)\n");
                    break;
                case 12:
                    status.Append($"ARM64\n");
                    break;
                default:
                    status.Append($"Unknown architecture\n");
                    break;
            }
            status.Append($"Number of processors:   {dwNumberOfProcessors}\n");
            status.Append($"Processor type:         {dwProcessorType}\n");
            status.Append($"Processor level:        {wProcessorLevel}\n");
            status.Append($"Processor revision:     {wProcessorRevision}\n");
            return status.ToString();
        }
    }
}
