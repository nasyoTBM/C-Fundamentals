using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split(new char[] { ' ' }).Select(int.Parse).ToArray();
        int sum = int.Parse(Console.ReadLine());
        for (int i = 0; i < input.Length; i++)
        {
            for (int j = i+1; j < input.Length; j++)
            {
                if (input[i]+input[j]==sum)
                {
                    Console.WriteLine(input[i]+" "+input[j]);
                }
            }
        }
    }
}

