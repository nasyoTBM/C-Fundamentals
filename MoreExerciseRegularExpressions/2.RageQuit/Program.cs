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
            string pattern = @"([^\d]+)(\d)";
            string input = Console.ReadLine().ToUpper();
            Dictionary<string, int> book = new Dictionary<string, int>();
            MatchCollection singles = Regex.Matches(input, pattern);
            foreach (Match match in singles)
            {
                book.Add(match.Groups[1].Value, int.Parse(match.Groups[2].Value));
            }
            foreach (var item in book)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            Console.WriteLine(input.Distinct().Count());
        }
    }
}
