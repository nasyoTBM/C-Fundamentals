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
        string[] makeRandom = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        Random rnd = new Random();
        for (int i = 0; i < makeRandom.Length; i++)
        {
            int random = rnd.Next(0, makeRandom.Length);
            string temp = makeRandom[i];
            makeRandom[i] = makeRandom[random];
            makeRandom[random] = temp;

        }
        Console.WriteLine(string.Join(Environment.NewLine,makeRandom));
    }
}

