using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.AsciiSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            string random = Console.ReadLine();
            int start = Math.Min((int)first, (int)second);
            int end = Math.Max((int)first, (int)second);
            int result = 0;
            for (int i = 0; i < random.Length; i++)
            {
                int current = (int)random[i];
                
                    if (current>start&&current<end)
                    {
                        result += current;
                    }
                
            }
            
            Console.WriteLine(result);
        }
    }
}
