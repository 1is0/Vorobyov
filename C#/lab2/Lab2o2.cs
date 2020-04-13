using System;
using System.Text;
using System.IO;

namespace Lab2o2
{
    //task 13 from tasklist
    class Lab2o2
    {
        static void Main(string[] args)
        {
            const byte numofSymbols = 30;
            const int numofLetters = 256; 
            StringBuilder letters;
            while (true)
            {
                Console.WriteLine("Enter a string, that consists of 256 english letters:");
                Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));
                letters = new StringBuilder(Console.ReadLine());
                if (letters.Length!= numofLetters)
                {
                    Console.Clear();
                    Console.WriteLine("Incorrect input, repeat");
                    continue;
                }

                int i = 0;
                for (; i < numofLetters; i++)
                {
                    if (!char.IsLetter(letters[i]))
                    {
                        Console.Clear();
                        Console.WriteLine("Incorrect input, repeat");
                        break;
                    }
                }

                if (i != numofLetters)
                    continue;

                break;
            }

            byte[] sequence = new byte[numofSymbols];
            Random random = new Random();
            random.NextBytes(sequence);
            Console.WriteLine();
            for (int i = 0; i < numofSymbols; i++)
            {
                Console.Write("{0} ", letters[sequence[i]]);
            }
            Console.WriteLine("\nPress any key to proceed...");
            Console.ReadKey();
        }
    }
}
