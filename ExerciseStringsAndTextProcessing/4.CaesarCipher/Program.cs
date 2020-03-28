using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = "";
            
            foreach (var item in input)
            {
                int val = item+3;
                char ch = (char)val;

                output += ch;
            }
            Console.WriteLine(output);
        }
    }
}
