using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseStringArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string temp = string.Empty;
            for (int i = 0; i < input.Length/2; i++)
            {
                temp = input[i];
                input[i] = input[input.Length - 1 - i];
                input[input.Length - 1 - i] = temp;
            }
            Console.WriteLine(string.Join(" ",input));
        }
    }
}
