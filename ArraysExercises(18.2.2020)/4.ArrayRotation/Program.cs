using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int moves = int.Parse(Console.ReadLine());
        for (int j = 0; j < moves; j++)
        {
            int temp = input[0];

            for (int i = 0; i < input.Length; i++)
            {


                if (i < input.Length - 1)
                {
                    input[i] = input[i + 1];
                }



            }
            input[input.Length - 1] = temp;
        }
        
        Console.WriteLine(string.Join(" ",input));
    }
}

