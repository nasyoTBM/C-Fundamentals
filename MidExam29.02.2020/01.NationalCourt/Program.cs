using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int firstEmployee = int.Parse(Console.ReadLine());
        int secondEmployee = int.Parse(Console.ReadLine());
        int thirdEmployee = int.Parse(Console.ReadLine());
        int peopleCount = int.Parse(Console.ReadLine());
        int totalHours = 0;
        int employeesToghether = firstEmployee + secondEmployee + thirdEmployee;
        while (peopleCount > 0)
        {

            totalHours++;
            if (totalHours % 4 == 0)
            {
                continue;
            }
            peopleCount -= employeesToghether;
        }
        Console.WriteLine($"Time needed: {totalHours}h.");
    }
}

