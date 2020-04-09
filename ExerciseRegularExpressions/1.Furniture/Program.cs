using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @">>([A-Z a-z]+)<<(\d+\.?\d+)!(\d+)\b";
            List<string> items = new List<string>();
            double totalPrice = 0;
            
            while (input!="Purchase")
            { 
                
                MatchCollection validProducts = Regex.Matches(input,pattern);
                foreach (Match item in validProducts)
                {
                    string name = item.Groups[1].Value;
                    double price = double.Parse(item.Groups[2].Value);
                    int quantity = int.Parse(item.Groups[3].Value);
                    items.Add(name);
                    totalPrice += price * quantity;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(Environment.NewLine,items));
            Console.WriteLine($"Total money spend: {totalPrice:F2}");
        }
    }
}
