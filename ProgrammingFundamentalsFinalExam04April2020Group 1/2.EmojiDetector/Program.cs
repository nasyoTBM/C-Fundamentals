using System;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger coolThreshHold = 1;


            string emojiPattern = @"([\:]{2}|[\*]{2})([A-Z][a-z]{2,})\1";
            string diggitPattern = @"-?[0-9]{1}";
            string input = Console.ReadLine();

            MatchCollection validNumbers = Regex.Matches(input, diggitPattern);
            foreach (Match num in validNumbers)
            {
                int singleNum = int.Parse(num.Value);
                coolThreshHold *= singleNum;
            }
            
            MatchCollection validEmojis = Regex.Matches(input, emojiPattern);

            List<string> coolEmojis = new List<string>();

            foreach (Match emoji in validEmojis)
            {
                int coolness = 0;
                string current = emoji.Groups[2].Value;
                for (int i = 0; i < current.Length; i++)
                {
                    coolness += (int)current[i];
                }
                if (coolness >= coolThreshHold)
                {
                    coolEmojis.Add(emoji.Value.Trim());
                }
                
            }
            Console.WriteLine($"Cool threshold: {coolThreshHold.ToString()}");
            Console.WriteLine($"{validEmojis.Count} emojis found in the text. The cool ones are:");
            Console.WriteLine(string.Join(Environment.NewLine, coolEmojis));

        }

    }
}