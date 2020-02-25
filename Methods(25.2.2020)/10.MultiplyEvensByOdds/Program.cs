using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int input = Math.Abs(int.Parse(Console.ReadLine()));
        Console.WriteLine(GetMultipleOfEvenAndOdds(GetSumOfEvenDigits(input), GetSumOfOddDigits(input)));
    }
    static int GetSumOfEvenDigits(int number)
    {
        int result = 0;
        while (number != 0)
        {
            int singleDigit = number % 10;
            if (singleDigit % 2 == 0)
            {
                result += singleDigit;
            }

            number -= singleDigit;
            number /= 10;
        }
        return result;
    }
    static int GetSumOfOddDigits(int number)
    {
        int result = 0;
        while (number != 0)
        {
            int singleDigit = number % 10;
            if (singleDigit % 2 != 0)
            {
                result += singleDigit;
            }

            number -= singleDigit;
            number /= 10;
        }
        return result;
    }
    static int GetMultipleOfEvenAndOdds(int a, int b)
    {
        return a * b;
    }


}
