using System;

namespace _3.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string substringToRemove = Console.ReadLine();
            string fulString = Console.ReadLine();
            while (fulString.Contains(substringToRemove))
            {
                int startIndex = fulString.IndexOf(substringToRemove);
                fulString = fulString.Remove(startIndex, substringToRemove.Length);
            }
            Console.WriteLine(fulString);
        }
    }
}
