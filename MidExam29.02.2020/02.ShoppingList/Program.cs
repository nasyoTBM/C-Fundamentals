using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<string> groceries = Console.ReadLine().Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        string input = Console.ReadLine();
        while (input!= "Go Shopping!")
        {
            string[] command = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            switch (command[0])
            {
                case "Urgent":
                    if (groceries.Contains(command[1]))
                    {
                        break;
                    }
                    else
                    {
                        groceries.Insert(0, command[1]);
                    }
                    break;
                case "Unnecessary":
                    if (groceries.Contains(command[1]))
                    {
                        groceries.Remove(command[1]);
                    }
                    
                    break;
                case "Correct":
                    if (groceries.Contains(command[1]))
                    {
                        groceries.Insert(groceries.IndexOf(command[1]), command[2]);
                        groceries.Remove(command[1]);
                    }
                    break;
                case "Rearrange":
                    if (groceries.Contains(command[1]))
                    {
                        groceries.Remove(command[1]);
                        groceries.Insert(groceries.Count, command[1]);
                    }
                        break;
                default:
                    break;
            }

            input = Console.ReadLine();

        }
        Console.WriteLine(string.Join(", ",groceries));
    }
    
}

