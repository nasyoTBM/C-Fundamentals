using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingClasses;

class Program
{
    static void Main()
    {
        BaseCat b1 = new BaseCat();
        DerivedCat d1 = new DerivedCat();

        b1.Name = "Mary";
        d1.Name = "John";

        b1.Color = "White";
        d1.Color = "Black";  // The BaseCat.Color property is called.

        System.Console.WriteLine("Base: {0}, {1}", b1.Name, b1.Color);
        System.Console.WriteLine("Derived: {0}, {1}", d1.Name, d1.Color);

        // Keep the console window open in debug mode.

    }
}