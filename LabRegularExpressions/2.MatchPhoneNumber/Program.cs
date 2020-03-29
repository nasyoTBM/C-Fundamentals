using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\+359([\s-]{1})2\1\d{3}\1\d{4}\b";
            Regex regex = new Regex(pattern);
            MatchCollection matchedPhones = regex.Matches(input);
            List<string> result = matchedPhones.Cast<Match>().Select(m => m.Value).ToList();
            Console.WriteLine(string.Join(", ",result));


        }
    }
}
