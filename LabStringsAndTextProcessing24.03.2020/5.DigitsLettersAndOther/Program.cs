using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string digits = "";
            string letters = "";
            string symbols = "";
            foreach (var item in input.ToCharArray())
            {
                if (char.IsDigit(item))
                {
                    digits += item;
                }
                else if (char.IsLetter(item))
                {
                    letters += item;
                }
                else
                {
                    symbols += item;
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(symbols);
        }
    }
}
