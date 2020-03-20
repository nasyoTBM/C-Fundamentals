using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            Dictionary<string, int> result = new Dictionary<string, int>();
            while (input!="stop")
            {
                int quantity = int.Parse(Console.ReadLine());


                if (!result.ContainsKey(input))
                {
                    result.Add(input, quantity);
                }
                else
                    result[input] += quantity;
                
                
                input = Console.ReadLine();

            }
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
