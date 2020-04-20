using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).ToArray();
            List<Product> menuProducts = new List<Product>();
            Dictionary<int, List<Product>> orders = new Dictionary<int, List<Product>>();

            while (!int.TryParse(input[0],out int random))
            {
                string type = input[0];
                string name = input[1];
                int weight = int.Parse(input[2]);
                decimal price = decimal.Parse(input[3]);

                if (type == "MainDish")
                {
                    MainDish mainDish = new MainDish();
                    mainDish.Type = type;
                    mainDish.Name = name;
                    mainDish.Weight = weight;
                    mainDish.Price = price;
                    menuProducts.Add(mainDish);
                }
                else if (type == "Drink")
                {
                    Drink drink = new Drink();
                    drink.Type = type;
                    drink.Name = name;
                    drink.Weight = weight;
                    drink.Price = price;
                    menuProducts.Add(drink);
                }
                else if (type == "Desert")
                {
                    Desert desert = new Desert();
                    desert.Type = type;
                    desert.Name = name;
                    desert.Weight = weight;
                    desert.Price = price;
                    menuProducts.Add(desert);
                }
                else if (type == "Salad" || type == "Soup")
                
                {

                    Product product = new Product();
                    product.Type = type;
                    product.Name = name;
                    product.Weight = weight;
                    product.Price = price;
                    menuProducts.Add(product);
                }
                else
                {
                    Console.WriteLine("invalid article");
                }
                input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).ToArray();
            }
            while (input[0]!="Exit")
            {
                int table = int.Parse(input[0]);
                MakeOrder(table, orders, input, menuProducts);
                
                input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).ToArray();
            }
            Console.WriteLine($"Tables total count: {orders.Count}");
            TotalSales(orders);
        }
        static void MakeOrder(int table,Dictionary<int, List<Product>> orders,string[] input, List<Product> menuProducts)
        {
            int index = 0;
            

            for (int i = 1; i < input.Length; i++)
            {
                
                if (menuProducts.Any(s=>s.Name==input[i]))
                {
                    index = menuProducts.FindIndex(s => s.Name == input[i]);
                    

                }
                if (orders.ContainsKey(table)&&index!=0)
                {
                    orders[table].Add(menuProducts[index]);
                }
                
            }
        }
        static void TotalSales(Dictionary<int, List<Product>> orders)
        {
            int totalSalesCount = orders.Values.Count;
            decimal totalSalesSum = 0;
            foreach (var item in orders)
            {
                foreach ( var article in item.Value)
                {
                    totalSalesSum += article.Price;
                }
            }
            Console.WriteLine($"Total sales: {totalSalesCount} - {totalSalesSum:F2}");
        }
    }
}
