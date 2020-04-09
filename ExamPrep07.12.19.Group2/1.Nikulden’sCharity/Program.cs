using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Nikulden_sCharity
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();
            while (command!="Finish")
            {
                string[] commands = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (commands[0] == "Replace")
                {
                    char currentChar = char.Parse(commands[1]);
                    char newChar = char.Parse(commands[2]);
                    input = input.Replace(currentChar, newChar);
                    Console.WriteLine(input);
                }
                else if (commands[0]=="Cut")
                {
                    int start = int.Parse(commands[1]);
                    int end = int.Parse(commands[2]);
                    CutString(input, start, end);
                }
                else if (commands[0]=="Make")
                {
                    if (commands[1]=="Upper")
                    {
                        input = input.ToUpper();
                        Console.WriteLine(input);
                    }
                    else
                    {
                        input = input.ToLower();
                        Console.WriteLine(input);
                    }
                }
                else if (commands[0]=="Check")
                {
                    string toCheck = commands[1];
                    if (input.Contains(toCheck))
                    {
                        Console.WriteLine($"Message contains {toCheck}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {toCheck}");
                    }
                }
                else if (commands[0]=="Sum")
                {
                    int start = int.Parse(commands[1]);
                    int end = int.Parse(commands[2]);
                    SumString(input, start, end);
                }

                command = Console.ReadLine();

            }
        }
        
        static void CutString(string input,int start,int end)
        {
            if (start >= 0 && end < input.Length)
            {
                int length = end - start + 1;

                input = input.Remove(start, length);

                Console.WriteLine(input);
            }
            else
            {
                Console.WriteLine("Invalid indexes!");
            }
        }
        static void SumString(string input,int start,int end)
        {
            int result = 0;
            if (start > input.Length || start < 0)
            {
                Console.WriteLine("Invalid indexes!");
                return;
            }
            else if (end > input.Length || end < 0 )
            {
                Console.WriteLine("Invalid indexes!");
                return;
            }
            else
            {
                string sub = input.Substring(start, end);
                
                for (int i = 0; i < sub.Length; i++)
                {
                    result += (int)sub[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}
