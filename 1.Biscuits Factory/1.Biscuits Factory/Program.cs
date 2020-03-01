using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int bisquitPerWorker = int.Parse(Console.ReadLine());
        int workersCount = int.Parse(Console.ReadLine());
        int competingFactoryTotal = int.Parse(Console.ReadLine());
        int total = 0;
        int difference = 0;
        for (int i = 0; i < 30; i++)
        {
            if (i % 3 == 0)
            {
                total += workersCount * bisquitPerWorker * 75 / 100;

            }
            else
            {
                total += workersCount * bisquitPerWorker;
            }
        }
        Console.WriteLine($"You have produced {total} biscuits for the past month.");
        difference = Math.Abs(total - competingFactoryTotal);
        double percentageDifference = difference * 1.0 / competingFactoryTotal;
        percentageDifference *= 100;
        if (total > competingFactoryTotal)
        {
            Console.WriteLine($"You produce {percentageDifference:F2} percent more biscuits.");
        }
        else
        {
            Console.WriteLine($"You produce {percentageDifference:F2} percent less biscuits.");
        }




    }
}

