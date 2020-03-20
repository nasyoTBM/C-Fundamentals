using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] input = Console.ReadLine().Where(x => !Char.IsWhiteSpace(x)).ToArray();
            Dictionary<char, int> counter = new Dictionary<char, int>();

            foreach (var item in input)
            {
                
                if (counter.ContainsKey(item))
                {
                    counter[item]++;
                }
                else
                {
                    counter.Add(item, 1);
                }
            }
            foreach (var item in counter)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
