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
                if (input[0] == "Sales")
                {
                    Console.WriteLine($"Tables total count: {orders.Count}");
                    TotalSales(orders);
                    Console.WriteLine("By categories: ");
                    PrintSalad(orders);
                    PrintSoup(orders);
                    PrintMainDish(orders);
                    PrintDesert(orders);
                    PrintDrink(orders);
                    input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).ToArray();
                    continue;
                }
                int table = int.Parse(input[0]);
                MakeOrder(table, orders, input, menuProducts);
                
                input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).ToArray();
            }
            Console.WriteLine($"Tables total count: {orders.Count}");
            TotalSales(orders);
            Console.WriteLine("By categories: ");
            PrintSalad(orders);
            PrintSoup(orders);
            PrintMainDish(orders);
            PrintDesert(orders);
            PrintDrink(orders);
        }
        static void MakeOrder(int table,Dictionary<int, List<Product>> orders,string[] input, List<Product> menuProducts)
        {
            
            

            for (int i = 1; i < input.Length; i++)
            {
                
                
                   int index = menuProducts.FindIndex(s => s.Name == input[i]);
                    

                
                
                    if (orders.ContainsKey(table))
                    {
                        orders[table].Add(menuProducts[index]);
                    }
                    else
                    {
                        orders.Add(table,new List<Product>());
                        orders[table].Add(menuProducts[index]);
                    }
                
                
                
            }
        }
        static void TotalSales(Dictionary<int, List<Product>> orders)
        {
            int totalSalesCount = 0;
            decimal totalSalesSum = 0;
            foreach (var item in orders)
            {
                foreach ( var article in item.Value)
                {
                    totalSalesCount++;
                    totalSalesSum += article.Price;
                }
            }
            Console.WriteLine($"Total sales: {totalSalesCount} - {totalSalesSum:F2}");
        }
        static void PrintSalad(Dictionary<int, List<Product>> orders)
        {
            int typeCounter = 0;
            decimal typeSumCounter = 0;
            foreach (var item in orders)
            {
                foreach (var article in item.Value)
                {
                    if (article.Type=="Salad")
                    {
                        typeCounter++;
                        typeSumCounter += article.Price;
                    }
                }
            }
            Console.WriteLine($"*   Salad: {typeCounter} - {typeSumCounter:F2}");
        }
        static void PrintSoup(Dictionary<int, List<Product>> orders)
        {
            int typeCounter = 0;
            decimal typeSumCounter = 0;
            foreach (var item in orders)
            {
                foreach (var article in item.Value)
                {
                    if (article.Type == "Soup")
                    {
                        typeCounter++;
                        typeSumCounter += article.Price;
                    }
                }
            }
            Console.WriteLine($"*   Soup: {typeCounter} - {typeSumCounter:F2}");
        }
        static void PrintMainDish(Dictionary<int, List<Product>> orders)
        {
            int typeCounter = 0;
            decimal typeSumCounter = 0;
            foreach (var item in orders)
            {
                foreach (var article in item.Value)
                {
                    if (article.Type == "MainDish")
                    {
                        typeCounter++;
                        typeSumCounter += article.Price;
                    }
                }
            }
            Console.WriteLine($"*   MainDish: {typeCounter} - {typeSumCounter:F2}");
        }
        static void PrintDesert(Dictionary<int, List<Product>> orders)
        {
            int typeCounter = 0;
            decimal typeSumCounter = 0;
            foreach (var item in orders)
            {
                foreach (var article in item.Value)
                {
                    if (article.Type == "Desert")
                    {
                        typeCounter++;
                        typeSumCounter += article.Price;
                    }
                }
            }
            Console.WriteLine($"*   Desert: {typeCounter} - {typeSumCounter:F2}");
        }
        static void PrintDrink(Dictionary<int, List<Product>> orders)
        {
            int typeCounter = 0;
            decimal typeSumCounter = 0;
            foreach (var item in orders)
            {
                foreach (var article in item.Value)
                {
                    if (article.Type == "Drink")
                    {
                        typeCounter++;
                        typeSumCounter += article.Price;
                    }
                }
            }
            Console.WriteLine($"*   Drink: {typeCounter} - {typeSumCounter:F2}");
        }
    }
}
