using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.CountRealNumbers
{
    class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Dictionary<int, int> output = new Dictionary<int, int>();
            for (int i = 0; i < input.Count; i++)
            {
                if (output.ContainsKey(input[i]))
                {
                    output[input[i]]++;
                }
                else
                {
                    output.Add(input[i], 1);
                }
            }
            foreach (var item in output.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
