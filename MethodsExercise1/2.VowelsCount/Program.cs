using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower();
        VowelsCounter(input);
    }
    static void VowelsCounter(string input)
    {
        int counter = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == 'a' || input[i] == 'u' || input[i] == 'o' || input[i] == 'e' || input[i] == 'i')
            {
                counter += 1;
            }
        }

        Console.WriteLine(counter);
    }
}

