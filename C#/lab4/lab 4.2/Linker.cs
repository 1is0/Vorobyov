using System.Runtime.InteropServices;

namespace CustomDllLink
{
    class Linker
    {
        //chage this value for you own path to CustomDll.dll
        private const string path = @"D:\Progs\CustomDll\Debug\CustomDll.dll";

        [DllImport(path, EntryPoint = "diagonal", CallingConvention = CallingConvention.StdCall)]
        public static extern double Diagonal(double a, double b);

        [DllImport(path, EntryPoint = "perimetr", CallingConvention = CallingConvention.StdCall)]
        public static extern double Perimetr(double a, double b);

        [DllImport(path, EntryPoint = "square", CallingConvention = CallingConvention.Cdecl)]
        public static extern double Square(double a, double b);

    }
}
