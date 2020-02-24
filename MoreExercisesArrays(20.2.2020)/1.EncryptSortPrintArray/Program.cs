using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] output = new int[n];
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            char[] converter = input.ToCharArray();
            int result = 0;
            for (int j = 0; j < converter.Length; j++)
            {
                if (converter[j] == 'a' || converter[j] == 'u' || converter[j] == 'o' || converter[j] == 'e' || converter[j] == 'i' ||
                    converter[j] == 'A' || converter[j] == 'U' || converter[j] == 'O' || converter[j] == 'E' || converter[j] == 'I')
                {
                    result += converter[j] * converter.Length;
                }
                else
                {
                    result += converter[j] / converter.Length;
                }

            }
            output[i] = result;
        }
        Array.Sort(output);
        for (int i = 0; i < output.Length; i++)
        {
            Console.WriteLine(output[i]);
        }
    }
}

