using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _2.RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\D+)(\d+)";
            string input = Console.ReadLine().ToUpper();
           
            

            MatchCollection singles = Regex.Matches(input, pattern);
            StringBuilder sb = new StringBuilder();

            foreach (Match match in singles)
            {
                string message = match.Groups[1].Value;
                int count =int.Parse(match.Groups[2].Value);
            
            
            
           
                for (int i = 0; i < count; i++)
                {
                    sb.Append(message);
                }
            }
            Console.WriteLine($"Unique symbols used: {sb.ToString().Distinct().Count()}");
            Console.WriteLine(sb);


        }
    }
}
