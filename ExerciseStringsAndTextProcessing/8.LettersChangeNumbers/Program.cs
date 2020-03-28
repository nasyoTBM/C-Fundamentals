using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] toCalculate = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            double result = 0;
            foreach (var item in toCalculate)
            {
                double number = FindNumber(item);
                result+=Calculate(item, number);
            }
            Console.WriteLine($"{result:F2}");
            
            

        }
        static double FindNumber(string input)
        {
            string digit = "";
            double number = 0;
            char[] arr = input.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (char.IsDigit(arr[i]))
                {
                    digit += arr[i];
                }

            }
            number = int.Parse(digit);
            return number;
        }
        static double Calculate(string input, double number)
        {
            string splitter = number.ToString();
            string[] arr = input.Split(new string[] { splitter }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string firstLetter = arr[0];
            string secondLetter = arr[1];

            if (char.IsUpper(firstLetter[0]))
            {
                int alphaBetPosition = firstLetter[0] - 64;
                number /= alphaBetPosition;
            }
            else if (char.IsLower(firstLetter[0]))
            {
                int alphaBetPosition = firstLetter[0] - 96;
                number *= alphaBetPosition;
            }
            if (char.IsUpper(secondLetter[0]))
            {
                int alphaBetPosition = secondLetter[0] - 64;
                number -= alphaBetPosition;
            }
            else if (char.IsLower(secondLetter[0]))
            {
                int alphaBetPosition = secondLetter[0] - 96;
                number += alphaBetPosition;
            }

                return number;
        }
    }
}







                





