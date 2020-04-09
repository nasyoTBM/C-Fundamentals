using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string n = Console.ReadLine();
            while (n!= "Generate")
            {
                string[] commands = n.Split(new string[] { ">>>" }, StringSplitOptions.None).ToArray();
                
                if (commands[0]=="Contains")
                {
                    string substring = commands[1];
                    if (input.Contains(substring))
                    {
                        Console.WriteLine($"{input} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (commands[0]=="Flip")
                {

                    int start = int.Parse(commands[2]);
                    int end = int.Parse(commands[3]);
                    int endIndex = end - start;
                    string substring = input.Substring(start, endIndex);
                    if (commands[1]=="Upper")
                    {
                        input = input.Replace(substring, substring.ToUpper());
                    }
                    else if (commands[1]=="Lower")
                    {
                        input = input.Replace(substring, substring.ToLower());
                    }
                    Console.WriteLine(input);
                }
                else if (commands[0]=="Slice")
                {
                    int start = int.Parse(commands[1]);
                    int end = int.Parse(commands[2]);
                    int endIndex = end - start;
                    input = input.Remove(start, endIndex);
                    Console.WriteLine(input);
                }

                n = Console.ReadLine();
                    
            }
            Console.WriteLine($"Your activation key is: {input}");
        }
    }
}
