using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        //int[] greko = { 1, 1 };
        //if (input==1||input==2)
        //{
        //    Console.WriteLine(1);
        //    return;
        //}
        //for (int j = 0; j < input-2; j++)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < greko.Length; i++)
        //    {
        //        sum += greko[i];

        //    }
        //    greko[0] = greko[1];
        //    greko[1] = sum;

        //}
        //Console.WriteLine(greko[1]);
        Console.WriteLine(Fibonacci(input));

    }
    static int Fibonacci(int input)
    {
        if (input == 1 || input == 2)
        {
            return 1;
        }
        return Fibonacci(input - 1) + Fibonacci(input - 2);
    }
}

