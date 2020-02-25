using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string action = Console.ReadLine().ToLower();
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        switch (action)
        {
            case "add":
                Add(a, b);
                break;
            case "multiply":
                Multiply(a, b);
                break;
            case "Subtrack":
                Subtract(a, b);
                break;
            case "divide":
                Divide(a, b);
                break;

            default:
                break;
        }
    }
    static void Add(int a, int b)
    {
        Console.WriteLine(a + b);
    }
    static void Multiply(int a, int b)
    {
        Console.WriteLine(a * b);
    }
    static void Subtract(int a, int b)
    {
        Console.WriteLine(a - b);
    }
    static void Divide(int a, int b)
    {
        Console.WriteLine(a / b);
    }
}
