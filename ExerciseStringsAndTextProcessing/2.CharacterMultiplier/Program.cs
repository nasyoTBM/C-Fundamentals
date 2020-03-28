using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToArray();
            string first = input[0];
            string second = input[1];
            int max = Math.Max(first.Length, second.Length);
            int min = Math.Min(first.Length, second.Length);
            int total = 0;
            for (int i = 0; i < max; i++)
            {
                if (i < min)
                {
                    total += first[i] * second[i];
                    
                }
                if (i>=first.Length)
                {
                    total += second[i];
                }
                else if (i>=second.Length)
                {
                    total += first[i];
                }
                
            }
            Console.WriteLine(total);
        }
    }
}
