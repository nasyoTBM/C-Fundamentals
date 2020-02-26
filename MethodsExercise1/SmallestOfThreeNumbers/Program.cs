using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        int thirdNum = int.Parse(Console.ReadLine());
        PrintSmallestNumber(firstNum, secondNum, thirdNum);

    }
    static void PrintSmallestNumber(int a,int b,int c)
    {
        if (a<b && a<c)
        {
            Console.WriteLine(a);
        }
        else if (b<a && b<c)
        {
            Console.WriteLine(b);
        }
        else
        {
            Console.WriteLine(c);
        }
    }
}

