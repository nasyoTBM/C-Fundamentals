using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        double firstSide = double.Parse(Console.ReadLine());
        double secondSide = double.Parse(Console.ReadLine());
        double area = CalculateArea(firstSide, secondSide);
        Console.WriteLine(area);
    }
    static double CalculateArea(double a, double b)
    {
        return a * b;
    }
}

