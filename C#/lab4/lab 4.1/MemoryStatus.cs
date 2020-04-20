using System;
using System.Runtime.InteropServices;
using System.Text;

namespace UnmanagedCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public class MemoryStatus
    {
        uint dwLength;
        uint dwMemoryLoad;
        ulong ullTotalPhys;
        ulong ullAvailPhys;        
        ulong ullTotalPageFile;
        ulong ullAvailPageFile;
        ulong ullTotalVirtual;
        ulong ullAvailVirtual;
        ulong ullAvailExtendedVirtual;
        public MemoryStatus()
        {
            dwLength = (uint)Marshal.SizeOf(typeof(MemoryStatus));
        }

        public void ConvertToMB() 
        {
            ulong modifier = (ulong)Math.Pow(2, 20);
            ullTotalPhys /= modifier;
            ullAvailPhys /= modifier;
            ullTotalPageFile /= modifier;
            ullAvailPageFile /= modifier;
            ullTotalVirtual /= modifier;
            ullAvailVirtual /= modifier;
            ullAvailExtendedVirtual /= modifier;
        }

        public string MemStatus() 
        {
            StringBuilder status = new StringBuilder();
            status.Append($"Memory in use (%): {dwMemoryLoad, 75} %\n");
            status.Append($"Total size of physical memory: {ullTotalPhys ,63} MB\n");
            status.Append($"Total size of available physical memory: {ullAvailPhys, 53} MB\n");
            status.Append($"Size of the commited memory limit: {ullTotalPageFile, 59} MB\n");
            status.Append($"Size of available memory to commit: {ullAvailPageFile,58} MB\n");
            status.Append($"Total size of the user mode portion of the virtual address space of the calling process: " +
                $"{ullTotalPageFile} MB\n");
            status.Append($"Unreserved and uncommitted memory in the user mode portion of the virtual address space:" +
                $" {ullAvailVirtual, 5} MB\n");
            status.Append($"Unreserved and uncommitted memory in the extended portion of the virtual address space:" +
                $" {ullAvailExtendedVirtual, 6} MB\n");
            return status.ToString();
        }
    }
}
