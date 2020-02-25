﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        PrintSign(n);

    }
    static void PrintSign(int number)
    {
        if (number > 0)
        {
            Console.WriteLine($"The number {number} is positive.");
        }
        else if (number == 0)
        {
            Console.WriteLine("The number 0 is zero.");
        }
        else
        {
            Console.WriteLine($"The number {number} is negative.");
        }
    }
}

