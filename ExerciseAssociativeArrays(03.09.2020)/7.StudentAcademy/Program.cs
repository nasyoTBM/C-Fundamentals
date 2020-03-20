using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            Dictionary<string, List<string>> output = new Dictionary<string, List<string>>();

            while (n != "End")
            {
                string[] input = n.Split(new string[] { " -> " }, StringSplitOptions.None).ToArray();
                string company = input[0];
                string employee = input[1];
                if (!output.ContainsKey(input[0]))
                {
                    output.Add(input[0], new List<string>());
                    output[input[0]].Add(input[1]);
                }
                else
                {
                    if (!output[input[0]].Contains(input[1]))
                    {
                        output[input[0]].Add(input[1]);
                    }
                    
                }
                n = Console.ReadLine();
            }
            foreach (var item in output.OrderBy(s=>s.Key))
            {
                Console.WriteLine(item.Key);
                foreach (var items in item.Value)
                {
                    Console.WriteLine($"-- {items}");
                }
            }
        }
    }
}
