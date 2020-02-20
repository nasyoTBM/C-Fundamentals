using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        int[] train = new int[count];

        for (int i = 0; i < count; i++)
        {
            train[i] = int.Parse(Console.ReadLine());
        }
        Console.Write(string.Join(" ", train));
        Console.WriteLine();
        Console.WriteLine(train.Sum());
    }
}

