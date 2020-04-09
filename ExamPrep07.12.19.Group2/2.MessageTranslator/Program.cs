using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2.MessageTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"\!([A-Z][a-z]{2,})\!\:\[([A-Z,a-z]{8,})\]";

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                MatchCollection validMessage = Regex.Matches(input, pattern);
                if (validMessage.Count!=0)
                {
                    foreach (Match command in validMessage)
                    {
                        string message = command.Groups[2].Value;
                        int[] result = new int[message.Length];
                        
                        for (int j = 0; j < result.Length; j++)
                        {
                            result[j] = (int)message[j];
                        }
                        Console.WriteLine($"{command.Groups[1].Value}: {String.Join(" ",result)}");
                    }
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }
                

            }
           

        }
    }
}
