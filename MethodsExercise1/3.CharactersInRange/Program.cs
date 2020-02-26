using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        char start = char.Parse(Console.ReadLine());
        char end = char.Parse(Console.ReadLine());
        PrintCharsInRange(start, end);

    }
    static void PrintCharsInRange(char a, char b)
    {
        int start = Math.Min(a, b);
        int end = Math.Max(a, b);
        for (int i = start + 1; i < end; i++)
        {
            Console.Write((char)i + " ");
        }
    }
}

