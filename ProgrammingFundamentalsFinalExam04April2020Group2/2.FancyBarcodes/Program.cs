using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2.FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            string pattern = @"[@][#]{1,}([A-Z][a-z A-Z \d]{4,}[A-Z])[@][#]{1,}";


            List<string> validCodes = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                MatchCollection validBarCodes = Regex.Matches(input, pattern);

                if (validBarCodes.Count == 0)
                {
                    Console.WriteLine("Invalid barcode");
                }
                else
                {
                    foreach (Match code in validBarCodes)
                    {
                        if (String.IsNullOrEmpty(ContainsNums(code.Groups[1].Value)))
                        {
                            Console.WriteLine("Product group: 00");
                        }

                        else
                        {
                            Console.WriteLine($"Product group: {ContainsNums(code.Groups[1].Value)}");

                        }
                    }
                }

            }

        }
        static string ContainsNums(string s)
        {
            string result = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    result += s[i];
                }
            }
            return result;
        }
    }

}