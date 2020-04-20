using System;

namespace UnmanagedCode
{
    class UnmanagedCode
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MachineInfo.GetMachineInfo());
            Console.ReadKey();
        }
    }
}
