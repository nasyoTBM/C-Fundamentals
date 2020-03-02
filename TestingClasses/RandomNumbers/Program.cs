using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Random random = new Random();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(random.Next(100,201));
        }
    }
}

