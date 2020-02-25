using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int userA = int.Parse(Console.ReadLine());
        char sign = char.Parse(Console.ReadLine());
        int userB = int.Parse(Console.ReadLine());
        Console.WriteLine(MathOperations(userA, sign, userB));

    }
    static double MathOperations(int a, char sign, int b)
    {
        double result = 0;
        switch (sign)
        {
            case '+':
                result = a + b;
                break;
            case '-':
                result = a - b;
                break;
            case '/':
                result = a / b;
                break;
            case '*':
                result = a * b;
                break;
            default:
                break;
        }
        return result;
    }
}


