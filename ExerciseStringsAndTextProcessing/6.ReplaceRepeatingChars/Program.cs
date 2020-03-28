using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            string output = "";
           

            for (int i = 0; i < input.Length; i++)
            {
                char temp = input[i];

                if (output.EndsWith(temp.ToString()))
                {
                    continue;
                }
                else
                {
                    output += temp;
                }

                
                
            }
            Console.Write(output);
        }
    }
}
