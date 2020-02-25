using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string command = Console.ReadLine();
        switch (command)
        {
            case "int":
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(a, b));
                break;
            case "char":
                char c = char.Parse(Console.ReadLine());
                char d = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(c, d));
                break;
            case "string":
                string e = Console.ReadLine();
                string f = Console.ReadLine();
                Console.WriteLine(GetMax(e, f));
                break;
            default:
                break;
        }
    }
    ///<summary>
    ///This function returns the greater value between two integers.
    ///</summary>
    static int GetMax(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
            return b;
    }
    ///<summary>
    ///This function returns the greater value between two chars.
    ///</summary>
    static char GetMax(char a, char b)
    {
        if (a > b)
        {
            return a;
        }
        else
            return b;
    }
    ///<summary>
    ///This function returns the greater value between two strings.
    ///</summary>
    static string GetMax(string a, string b)
    {
        int comparison = a.CompareTo(b);
        if (comparison > 0)
        {
            return a;
        }
        else
        {
            return b;
        }


    }
}

