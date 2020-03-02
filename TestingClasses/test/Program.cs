using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{

    static void Main()
    {
        System.Collections.Generic.List<int> ints = new System.Collections.Generic.List<int>(); System.Collections.Generic.List<double> doubles = new System.Collections.Generic.List<double>();

        while (true)
        {
            int intResult; double doubleResult;
            Console.WriteLine("Enter an int or a double: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out intResult))
            {
                ints.Add(intResult);
            }
            else if (double.TryParse(input, out doubleResult))
            {
                doubles.Add(doubleResult);
            }
            else
            {
                break;
            }
        }

        Console.Write("You entered {0} ints: ", ints.Count);
        foreach (var i in ints)
        {
            Console.Write(" " + i);
        }
        Console.WriteLine();

        Console.Write("You entered {0} doubles: ", doubles.Count);
        foreach (var d in doubles)
        {
            Console.Write(" " + d);
        }
        Console.WriteLine();

    }

}