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
        
        bool isTop = false;
        for (int i = 0; i < input.Length; i++)
        {
            for (int j = i+1; j < input.Length; j++)
            {

                if (input[i]>input[j])
                {
                    isTop = true;
                    
                }
                else
                {
                    isTop = false;
                    break;
                }
            }
            if (i==input.Length-1)
            {
                isTop = true;
            }

            if (isTop)
            {
                Console.Write(input[i]+" ");
            }
        }
    }
}
