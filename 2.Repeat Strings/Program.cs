using System;

namespace _2.Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                  .Split();
            string rezult = "";
            foreach (string word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    rezult += word;
                }
            }
            Console.WriteLine(rezult);
        }
    }
}
