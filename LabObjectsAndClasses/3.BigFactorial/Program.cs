using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


class Program
{
    public static Random rnd = new Random();
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        BigInteger result =1;
        for (int i = 2; i < num+1; i++)
        {
            result *= i;
        }
        Console.WriteLine(result);
    }
    private static void InsertAtRandomPosition(StringBuilder password, char character) 
    {
        int randomPosition = rnd.Next(password.Length + 1);
        password.Insert(randomPosition, character); 
    }
}
