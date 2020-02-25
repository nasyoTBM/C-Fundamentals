using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        double grade = double.Parse(Console.ReadLine());
        PrintGrade(grade);
    }
    static void PrintGrade(double n)
    {
        if (n >= 2.00 && n <= 2.99)
        {
            Console.WriteLine("Fail");
        }
        else if (n >= 3.00 && n <= 3.49)
        {
            Console.WriteLine("Poor");
        }
        else if (n >= 3.50 && n <= 4.49)
        {
            Console.WriteLine("Good");
        }
        else if (n >= 4.50 && n <= 5.49)
        {
            Console.WriteLine("Very good");
        }
        else if (n >= 5.50 && n <= 6.00)
        {
            Console.WriteLine("Excellent");
        }
    }
}

