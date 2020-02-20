using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] condensed = new int[input.Length - 1];
            while (condensed.Length!=1)
            {
                if (input.Length==1)
                {
                    Console.WriteLine(string.Join(" ", input));
                    return;
                }
                condensed = new int[input.Length - 1];
                for (int i = 0; i < input.Length-1; i++)
                {
                    condensed[i] = input[i] + input[i + 1];

                }
                input = condensed;
                
            }
            Console.WriteLine(string.Join(" ",condensed));
                
            
            
        }
    }
}
