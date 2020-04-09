using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _6.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"[\s][a-z0-9]+[\-_\.]?[a-z]*@[a-z\-]+\.[a-z]+[\.]?[a-z]+";
            MatchCollection validMails = Regex.Matches(input, pattern);
            foreach (Match item in validMails)
            {
                
                Console.WriteLine(item.Value.Trim());
            }
        }
    }
}
