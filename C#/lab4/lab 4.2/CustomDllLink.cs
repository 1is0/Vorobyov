using System;

namespace CustomDllLink
{
    class CustomDllLink
    {
        static void Main(string[] args)
        {
            double a = 12.5;
            double b = 13.2;
            Console.WriteLine($"{ "Rectangle Simple Info App", 70}");
            Console.WriteLine($"Rectangle with sides {a:F} and {b:F}:");
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Diagonal equals {Linker.Diagonal(a, b):F}");
            Console.WriteLine($"Perimetr equals {Linker.Perimetr(a, b):F}");
            Console.WriteLine($"Square equals   {Linker.Square(a, b):F}");
            Console.ReadKey();
        }
    }
}
