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
        int sum = input.Sum();
        int checkSum = 0;
        for (int i = 0; i < input.Length; i++)
        {
            sum -= input[i];
            if (sum == checkSum)
            {
                Console.WriteLine(i);
                return;
            }

            checkSum += input[i];
        }
        if (sum != checkSum)
        {
            Console.WriteLine("no");
        }



    }
}

