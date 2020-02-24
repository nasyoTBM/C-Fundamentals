using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split(new char[] { ' ' }).Select(int.Parse).ToArray();
        int k = input.Length / 4;
        int[] firstRow = new int[2 * k];
        int[] secondRow = new int[2 * k];
        int counter = 0;
        int counter2 = 0;
        int[] result = new int[2*k];
        
        for (int i = 0; i < k; i++)
        {
            firstRow[i] = input[k - 1 - i];
        }
        for (int i = input.Length-1; i >= k*3; i--)
        {
            firstRow[k+counter] = input[i];
            counter++;
        }
        for (int i = k; i < input.Length-k; i++)
        {

            secondRow[counter2] = input[i];
            counter2++;
        }
        
        for (int i = 0; i < firstRow.Length; i++)
        {
            result[i]=firstRow[i] + secondRow[i];
        }
        Console.WriteLine(string.Join(" ", result));
        
    }
}

