using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2.Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int countSuccessfull = 0;
            string pattern = @"U\$([A-Z][a-z]{2,})U\$P\@\$([a-z]{5,}\d+)P\@\$";
            for (int i = 0; i < n; i++)
            {
                
                string input = Console.ReadLine();
                MatchCollection validInput = Regex.Matches(input, pattern);
                if (validInput.Count!=0)
                {
                    countSuccessfull++;
                    Console.WriteLine("Registration was successful");
                    foreach (Match user in validInput)
                    {
                        Console.WriteLine($"Username: {user.Groups[1].Value}, Password: { user.Groups[2].Value}");
                        
                    }
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
                
            }
            Console.WriteLine($"Successful registrations: {countSuccessfull}");
        }
        
    }
}
