using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').Where(s => s.Length % 2 == 0).ToArray();
            Console.WriteLine(string.Join(Environment.NewLine,input));
        }
    }
}
