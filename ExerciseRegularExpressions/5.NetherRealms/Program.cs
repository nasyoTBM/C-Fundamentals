using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _5.NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] demons = Console.ReadLine().Split(',').Select(s => s.Trim()).ToArray();
            foreach (var demon in demons.OrderBy(s=>s))
            {
                Console.WriteLine($"{demon} - {GetDemonHealth(demon)} health, {GetDemonDamage(demon):F2} damage");
            }

        }
        static int GetDemonHealth(string demon)
        {
            int result = 0;
            string pattern = @"[^0-9\+\-\*\/\.]";
            MatchCollection validate = Regex.Matches(demon, pattern);
            string name = "";
            foreach (Match match in validate)
            {
                name += match.Value;
            }
            for (int i = 0; i < name.Length; i++)
            {
                result += (int)name[i];
            }
            return result;
        }
        static double GetDemonDamage(string demon)
        {
            string patternForNumbers = @"[\-]?[\d]+[\.]?[\d]*";
            string patternForOperations = @"[\/\*]";
            MatchCollection validNumbers = Regex.Matches(demon, patternForNumbers);
            MatchCollection validOperations = Regex.Matches(demon, patternForOperations);
            double baseDamage = 0;
            foreach (Match num in validNumbers)
            {
                baseDamage += double.Parse(num.Value);
            }
            if (baseDamage!=0 && validOperations.Count!=0)
            {
                foreach (Match operation in validOperations)
                {
                    if (operation.Value=="/")
                    {
                        baseDamage /= 2;
                    }
                    else
                    {
                        baseDamage *= 2;
                    }
                }
            }
            return baseDamage;
        }
    }
}
