using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace _1.WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine().Split(',').Select(s => s.Trim()).ToArray();

            Regex regex = new Regex(@"[\$]{6,10}|[\@]{6,10}|[\#]{6,10}|[\^]{6,10}");
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i].Length!=20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                else 
                {
                    
                    string firstHalft = regex.Match(tickets[i], 0, 10).Value;
                    string secondHalf = regex.Match(tickets[i], 10).Value;
                    if (!string.IsNullOrEmpty(firstHalft) && !string.IsNullOrEmpty(secondHalf))
                    {
                        if (firstHalft.Length==10 && firstHalft.Contains(secondHalf))
                        {
                            Console.WriteLine($"ticket \"{tickets[i]}\" - {firstHalft.Length}{firstHalft[0]} Jackpot!");
                        }
                        else if (firstHalft.Contains(secondHalf))
                        {
                            Console.WriteLine($"ticket \"{tickets[i]}\" - {Math.Min(firstHalft.Length,secondHalf.Length)}{firstHalft[0]}");
                        }

                 
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{tickets[i]}\" - no match");
                    }

                    
                }
            }
        }
    }
}
