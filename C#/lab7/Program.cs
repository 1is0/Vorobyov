using System;

namespace Numbers
{
    class Program
    {
        delegate void ExceptionHandler();
        static void Main(string[] args)
        {
            Rationals[] rats = new Rationals[6];
            rats[0] = new Rationals();
            rats[1] = new Rationals(12, 13);
            rats[2] = "12,1345";
            rats[3] = "12.1345";
            rats[4] = 5555.5555;
            rats[5] = -999.99999;
            FormattingDemo(rats);
            ComparisonsDemo(rats);
            OperationsDemo(rats);
            MistakesDemo(rats);
            Console.ReadKey();
        }
        static void ColoredWriteLine(ConsoleColor clr, string msg)
        {
            Console.ForegroundColor = clr;
            Console.WriteLine(msg);
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void FormattingDemo(Rationals[] rats)
        {
            ColoredWriteLine(ConsoleColor.Green, $"{"ToString() method (or DoubleView()):\n",76}");
            for (int i = 0; i < rats.Length; i++)
            {
                Console.WriteLine("rationalsArray[{0}] = {1}", i, rats[i].ToString());
            }
            ColoredWriteLine(ConsoleColor.DarkGreen, "\n" + $"{"Scientific format:\n",65}");
            for (int i = 0; i < rats.Length; i++)
            {
                Console.WriteLine("rationalsArray[{0}] = {1}", i, rats[i].ScientificView());
            }
            ColoredWriteLine(ConsoleColor.Yellow, "\n" + $"{"Fraction format:\n",64}");
            for (int i = 0; i < rats.Length; i++)
            {
                Console.WriteLine("rationalsArray[{0}] = {1}", i, rats[i].FactionView());
            }
            ColoredWriteLine(ConsoleColor.DarkYellow, "\n" + $"{"Conversions from Rationals:\n",70}");
            Console.WriteLine("(double)rationalsArray[1] = {0}", (double)rats[1]);
            Console.WriteLine("(string)rationalsArray[0] = {0}", (string)rats[0]);
        }

        static void ComparisonsDemo(Rationals[] rats)
        {
            ColoredWriteLine(ConsoleColor.Red, "\n" + $"{"Demonstration of comparisons:\n",71}");
            Console.WriteLine("rationalsArray[0] >= 1.5?               {0}", rats[0] >= 1.5);
            Console.WriteLine("rationalsArray[1] <= rationalsArray[1]? {0}", rats[1] <= rats[1]);
            Console.WriteLine("rationalsArray[2] > 0?                  {0}", rats[2] > 0);
            Console.WriteLine("rationalsArray[3] < 12.123?             {0}", rats[3] < 12.123);
            Console.WriteLine("rationalsArray[4] == 555.5555555?       {0}", rats[4] == 555.5555555);
            Console.WriteLine("rationalsArray[5] != 17?                {0}", rats[5] != 17);
            Console.WriteLine("rationalsArray[5].Equals(-999.99999)?   {0}", rats[5].Equals(-999.99999));
        }
        static void OperationsDemo(Rationals[] rats)
        {
            ColoredWriteLine(ConsoleColor.Cyan, "\n" + $"{"Demonstration of operations:\n",70}");
            Console.WriteLine($"{rats[0].FactionView()} + 0 = {rats[0] + 0}");
            Console.WriteLine($"{rats[1]} - 5.6 = {rats[1] - 5.6}");
            Console.WriteLine($"{rats[2]} * 1.6 = {rats[2] * "1,6"}");
            Console.WriteLine($"{rats[3]}++ = {++rats[3]}");
            Console.WriteLine($"{rats[3]}-- = {--rats[3]}");
            Console.WriteLine($"{rats[5]} / 12 = {rats[5] / 12}");
            Console.WriteLine($"{rats[4]} /= 5: {rats[4] /= 5}");
        }
        static void MistakesDemo(Rationals[] rats)
        {
            ColoredWriteLine(ConsoleColor.Blue, "\n" + $"{"Demonstration of possible mistakes:\n",74}");            
            ExceptionHandler ex1 = () => 
            {
                Rationals r = rats[0] / 0;
            };

            ExceptionHandler ex2 = () =>
            {
                Rationals r = new Rationals(1, 0);
            };

            ExceptionHandler ex3 = delegate()
            {
                Rationals r = new Rationals(-1, 2);
            };

            ExceptionHandler ex4 = delegate ()
            {
                Rationals r = "Some wrong string";
            };

            ExceptionShow(ex1);
            ExceptionShow(ex2);
            ExceptionShow(ex3);
            ExceptionShow(ex4);

            void ExceptionShow(ExceptionHandler ex) 
            {
                try
                {
                    ex.Invoke();
                }
                catch (Exception e) 
                {
                    Console.WriteLine(e.Message);
                }
            }            
        }
    }
}
