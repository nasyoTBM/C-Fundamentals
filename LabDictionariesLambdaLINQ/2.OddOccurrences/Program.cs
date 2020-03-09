using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string[] splitted = input.Split(' ').Select(s => s.Trim()).ToArray();
            Dictionary<string, int> result = new Dictionary<string, int>();
            foreach (var item in splitted)
            {
                if (result.ContainsKey(item))
                {
                    result[item]++;
                }
                else
                {
                    result.Add(item, 1);
                }
            }
            foreach (var item in result)
            {
                if (item.Value%2!=0)
                {
                    Console.Write(item.Key + " ");
                }
            }
        }
    }
}
