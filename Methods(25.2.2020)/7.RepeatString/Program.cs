using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int count = int.Parse(Console.ReadLine());
        Console.WriteLine(PrintMany(input, count));
    }
    static string PrintMany(string input, int count)
    {
        string result = string.Empty;
        for (int i = 0; i < count; i++)
        {
            result += input;
        }
        return result;
    }
}

