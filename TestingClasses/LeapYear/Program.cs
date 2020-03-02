using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int year = int.Parse(Console.ReadLine());
        bool result = DateTime.IsLeapYear(year);
        if (result)
        {
            Console.WriteLine("Yes");
        }
        else
            Console.WriteLine("Nope");
    }

}
