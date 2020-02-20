using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split(new char[] { ' ' }).Select(int.Parse).ToArray();
        int counter = 1;
        int maxSequence = 1;
        int index = int.MinValue;
        for (int i = 0; i < input.Length - 1; i++)
        {
            if (input[i] == input[i + 1])
            {
                counter++;
                if (counter > maxSequence)
                {
                    maxSequence = counter;
                    index = input[i];
                }
            }


            else
            {
                counter = 1;
               
            }
        }
        if (index==int.MinValue)
        {
            Console.WriteLine(input[0]);
            return;
        }


        for (int i = 0; i < maxSequence; i++)
        {
            Console.Write(index + " ");
        }
    }
}


