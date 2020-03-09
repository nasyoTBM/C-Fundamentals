using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (result.ContainsKey(word))
                {
                    result[word].Add(synonym);
                }
                else
                {
                    result.Add(word, new List<string>());
                    result[word].Add(synonym);
                }
            }
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ",item.Value)}");
            }
        }
    }
}
