using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var result = input.OrderByDescending(x => x).Take(3).ToList();
            foreach (var item in result)
            {
                Console.Write(item+" ");
            }
        }
    }
}
