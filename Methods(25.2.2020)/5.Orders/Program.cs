using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        string product = Console.ReadLine();
        int count = int.Parse(Console.ReadLine());
        TotalPrice(product, count);
    }
    static void TotalPrice(string product, int count)
    {
        double total = 0;
        switch (product)
        {
            case "coffee":
                total = 1.50 * count;
                break;
            case "water":
                total = 1.00 * count;
                break;
            case "coke":
                total = 1.40 * count;
                break;
            case "snacks":
                total = 2.00 * count;
                break;

            default:
                break;
        }
        Console.WriteLine($"{total:F2}");
    }

}

