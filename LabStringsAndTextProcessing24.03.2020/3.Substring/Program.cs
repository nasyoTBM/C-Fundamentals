using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine().ToLower();
            string input = Console.ReadLine();
            while (input.Contains(wordToRemove))
            {
                int startIndex = input.IndexOf(wordToRemove);
                input = input.Remove(startIndex,wordToRemove.Length);
            }
            Console.WriteLine(input);
        }
    }
}
