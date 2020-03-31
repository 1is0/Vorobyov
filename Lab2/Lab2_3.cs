using System;

namespace Lab2_3
{
    //task 11 from tasklist
    class Lab2_3
    {
        public static void Main()
        {
            Console.WriteLine("Enter your string:");
            string str = Console.ReadLine();
            string[] words = str.Split(new char[] { ' ' });
            Console.WriteLine();
            foreach (string word in words)
            {
                if (word.IndexOf("...") != -1)
                {
                    Console.Write("...");
                }
                else if (word[word.Length - 1] == ';' || word[word.Length - 1] == ',' || word[word.Length - 1] == '.' || word[word.Length - 1] == '!' || word[word.Length - 1] == '?' || word[word.Length - 1] == ':' || word[word.Length - 1] == '\"' || word[word.Length - 1] == '\'')
                {
                    Console.Write(word[word.Length - 1]);
                }
                Console.Write(word + " ");
            }
            Console.WriteLine("\nPress any key to proceed...");
            Console.ReadKey();
        }
    }
}
