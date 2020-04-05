using System;
using System.Text;
using System.Globalization;

namespace Lab2o1
{
    //task 1 from tasklist
    class Lab2o1
    {
        static void Main(string[] args)
        {
            DateTime currentDate = DateTime.Now;
            StringBuilder strDate = new StringBuilder(currentDate.ToString("MMddyyyyHHmmss"));
            byte[] nums = new byte[10];
            for (int i = 0; i < strDate.Length; i++)
            {
                nums[strDate[i] - 48]++;
            }
            Console.WriteLine("Full date-time: {0}", currentDate.ToString("F", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine("Shortened date-time: {0:G}\n", currentDate);
            Console.WriteLine("\n Shortened notation:");
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i]!= 0)
                {
                    Console.WriteLine($"Number of {i}s = {nums[i]}");
                    nums[i] = 0;
                }
            }
            strDate.Clear();
            strDate.Append(currentDate.ToString("F", CultureInfo.CreateSpecificCulture("en-US")));
            for (int i = 0; i < strDate.Length; i++)
            {
                if(Char.IsNumber(strDate[i]))
                    nums[strDate[i] - 48]++;
            }
            Console.WriteLine("\n Full eng notation:");
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    Console.WriteLine($"Number of {i}s = {nums[i]}");
                    nums[i] = 0;
                }
            }
            Console.WriteLine("\nPress any key to proceed...");
            Console.ReadKey();            
        }
    }
}
