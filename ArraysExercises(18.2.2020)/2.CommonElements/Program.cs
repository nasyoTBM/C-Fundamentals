using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string[] first = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToArray();
        string[] second = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        
        for (int i = 0; i < second.Length; i++)
        {
            for (int j = 0; j < first.Length; j++)
            {
                if (second[i]==first[j])
                {
                    Console.Write(second[i]+" ");
                }
            }
        }
    }
}

