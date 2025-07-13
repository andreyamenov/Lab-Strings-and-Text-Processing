using System;

namespace _4.Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[]  bannedWords = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
            foreach (string bannedWord in bannedWords)
            { 
                string replacemant = new('*',bannedWord.Length);
                text = text.Replace(bannedWord, replacemant);
            }
            Console.WriteLine(text);
            

        }
    }
}
