using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            string input = Console.ReadLine();
            while (input!="Done")
            {
                
                List<string> commands = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
               
                if (commands[0] == "TakeOdd")
                {
                    string result = "";
                    for (int i = 0; i < n.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            result += n[i];
                        }
                    }
                    n = result;
                    Console.WriteLine(n);
                }

                if (commands[0] == "Cut")
                {
                    int index = int.Parse(commands[1]);
                    int length = int.Parse(commands[2]);
                    n = n.Remove(index, length);
                    Console.WriteLine(n);

                }

                if (commands[0] == "Substitute")
                {
                    string substring = commands[1];
                    string substitute = commands[2];
                    if (n.Contains(substring))
                    {
                        n = n.Replace(substring, substitute);
                        Console.WriteLine(n);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }


                input = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {n}");
        }
        
    }
}
