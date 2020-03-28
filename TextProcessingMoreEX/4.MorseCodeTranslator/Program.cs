using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, char> dictionary = new Dictionary<string, char>()
            {
                {".-",'A' },
                {"-...",'B'},
                {"-.-.",'C'},
                {"-..",'D'},
                {".",'E'},
                {"..-.",'F'},
                {"--.",'G'},
                {"....",'H' },
                {"..",'I' },
                {".---",'J' },
                {"-.-",'K' },
                {".-..",'L' },
                {"--",'M' },
                {"-.",'N' },
                {"---",'O' },
                {".--.",'P' },
                {"--.-",'Q'},
                {".-.",'R'},
                {"...",'S' },
                {"-",'T' },
                {"..-",'U' },
                {"...-",'V' },
                {".--",'W' },
                {"-..-",'X' },
                {"-.--",'Y' },
                {"--..",'Z' }
            };

            
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            StringBuilder result = new StringBuilder();
            foreach (var word in input)
            {
                if (dictionary.ContainsKey(word))
                {
                    result.Append(dictionary[word]);
                }
                else 
                {
                    result.Append(' ');
                }
            }
            Console.WriteLine(result);

        }
    }
}
