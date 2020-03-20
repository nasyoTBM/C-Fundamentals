using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> productQuantity = new Dictionary<string, int>();
            Dictionary<string, double> productPrice = new Dictionary<string, double>();
            string n = Console.ReadLine();
            while (n != "buy")
            {
                string[] input = n.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string product = input[0];
                double price = double.Parse(input[1]);
                int count = int.Parse(input[2]);

                if (productPrice.ContainsKey(product))
                {
                    productPrice[product] = price;
                }
                else
                {
                    productPrice.Add(product, price);
                }
                if (productQuantity.ContainsKey(product))
                {
                    productQuantity[product] += count;
                }
                else
                {
                    productQuantity.Add(product, count);
                }

                n = Console.ReadLine();
            }

            foreach (var item in productQuantity)
            {
                productPrice[item.Key] *= item.Value;
                
            }
            foreach (var item in productPrice)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:F2}");
            }


        }
    }
}
