using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4.StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
           
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string pattern = @"[starSTAR]";
                MatchCollection count = Regex.Matches(input, pattern);
                int decryptNumber = count.Count;
                string decryptedMessage = DecryptMessage(input, decryptNumber);
                ManagePlanet(decryptedMessage, attackedPlanets, destroyedPlanets);

            }
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var item in attackedPlanets.OrderBy(s=>s))
            {
                Console.WriteLine($"-> {item}");
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var item in destroyedPlanets.OrderBy(s => s))
            {
                Console.WriteLine($"-> {item}");
            }





        }
        static string DecryptMessage(string message,int decryptNumber)
        {
            string result = "";
            for (int i = 0; i < message.Length; i++)
            {
               result+=   (char)(message[i] - decryptNumber);
            }
            return result;
        }
        static void ManagePlanet(string decryptedMessage, List<string> attacked , List<string> destroyed)
        {
            string pattern = @"[^@,\-!:>]*@([A-Z]+[a-z]+)[^@,\-!:>]*:(\d+)[^@,\-!:>]*!([AD])![^@,\-!:>]*->(\d+)";
            MatchCollection validInput = Regex.Matches(decryptedMessage, pattern);
            foreach (Match item in validInput)
            {
                if (validInput.Count!=0)
                {
                    string name = item.Groups[1].Value;
                    string type = item.Groups[3].Value;
                    if (type == "A")
                    {
                        attacked.Add(name);
                    }
                    else 
                    {
                        destroyed.Add(name);
                    }
                }
            }
        }
        

    }
}
