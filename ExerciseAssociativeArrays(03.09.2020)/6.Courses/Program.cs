using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            Dictionary<string, List<string>> output = new Dictionary<string,List<string>>();

            while (n!="end")
            {
                string[] input = n.Split(new string[] { " : " }, StringSplitOptions.None).ToArray();
                if (output.ContainsKey(input[0]))
                {
                    output[input[0]].Add(input[1]);
                }
                else
                {
                    output.Add(input[0], new List<string>());
                    output[input[0]].Add(input[1]);
                }


                n = Console.ReadLine();
            }
            
            foreach (var item in output.OrderByDescending(s=>s.Value.Count))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (var items in item.Value.OrderBy(s=>s))
                {
                    Console.WriteLine($"-- {items}");
                }
                

            }
            

        }
    }
}
