using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input!="end")
            {
                string output = string.Empty;
                foreach (var item in input.Reverse().ToArray())
                {
                    output += item;
                }
                Console.WriteLine($"{input} = {output}");
                input = Console.ReadLine(); 
            }
        }
    }
}
