using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3.SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^\%([A-Z][a-z]+)\%[^|$%.]*\<(\w+)\>[^|$%.]*\|+(\d+)\|[^|$%.]*?(\d+\.?\d+)\$$";
            string input = Console.ReadLine();
            List<string> result = new List<string>();
            double total = 0;

            while (input!="end of shift")
            {
                MatchCollection valid = Regex.Matches(input, pattern);
                foreach (Match item in valid)
                {
                    string name = item.Groups[1].Value;
                    string product = item.Groups[2].Value;
                    int quantity = int.Parse(item.Groups[3].Value);
                    double price = double.Parse(item.Groups[4].Value);
                    result.Add($"{name}: {product} - {price*quantity:F2}");
                    total += price * quantity;

                }
                input = Console.ReadLine();
            }
            
            foreach (var item in result)
            {
                Console.WriteLine(item);
                
            }
            Console.WriteLine($"Total income: {total:F2}");
        }
    }
}
