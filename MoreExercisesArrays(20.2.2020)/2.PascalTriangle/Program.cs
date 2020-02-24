using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {

        int[] initial = { 1, 1 };
        int input = int.Parse(Console.ReadLine());
        if (input == 0 || input < 0)
        {

            return;
        }
        if (input == 1)
        {
            Console.WriteLine(1);
            return;
        }
        if (input == 2)
        {
            Console.WriteLine(1);
            Console.WriteLine(string.Join(" ", initial));
            return;
        }

        else
        {
            Console.WriteLine(1);
            Console.WriteLine(string.Join(" ", initial));
        }

            for (int j = 0; j < input - 2; j++)
            {
                int[] pascal = new int[initial.Length + 1];
                for (int i = 0; i < pascal.Length; i++)
                {
                    if (i == 0 || i == pascal.Length - 1)
                    {
                        pascal[i] = 1;
                    }
                    else
                    {
                        pascal[i] = initial[i - 1] + initial[i];
                    }
                }
                
                Console.WriteLine(string.Join(" ", pascal));
                initial = pascal;

            
        }
    }
}
