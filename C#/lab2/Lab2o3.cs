using System;
using System.Text;

namespace Lab2o3
{
    //task 11 from tasklist
    class Lab2o3
    {
        public static void Main()
        {
            Console.WriteLine("Enter your string:");
            string str = Console.ReadLine();            
            string[] words = str.Split(new char[] { ' ' });
            Console.WriteLine();
            StringBuilder result = new StringBuilder("");
            foreach (string word in words)
            {
                if (word.IndexOf("...") != -1)
                {
                    result.Append("...");
                }
                else if (word.EndsWith(";") || word.EndsWith(",") || word.EndsWith(".") || word.EndsWith("!") || word.EndsWith("?") || word.EndsWith(":") || word.EndsWith("\"") || word.EndsWith("\'"))
                {
                    result.Append(word[word.Length - 1]);
                }
                result.Append(word + " ");
            }
            Console.WriteLine(result);
            Console.WriteLine("\nPress any key to proceed...");
            Console.ReadKey();
        }
    }
}
