using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            // "{username}-{language}-{points}" until you receive "exam finished"
            Dictionary<string, List<string>> langName = new Dictionary<string, List<string>>();
            Dictionary<string, int> nameResult = new Dictionary<string, int>();
            string input = Console.ReadLine();
            while (input!="exam finished")
            {
                string[] command = input.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (command.Contains("banned"))
                {
                    string userName = command[0];
                    BanUser(nameResult, userName);
                }
                else
                {
                    string user = command[0];
                    string language = command[1];
                    int points = int.Parse(command[2]);
                    AddSubmisions(langName, user, language);
                    AddPoints(nameResult, user, points);
                }

                
                input = Console.ReadLine();

            }
            Console.WriteLine("Results:");
            foreach (var item in nameResult.OrderByDescending(s=>s.Value).ThenBy(s=>s.Key))
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var item in langName.OrderByDescending(s=>s.Value.Count).ThenBy(s=>s.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value.Count}");
            }

        }
        static Dictionary<string,List<string>> AddSubmisions(Dictionary<string,List<string>> langName,string name,string language)
        {
            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();

            if (!langName.ContainsKey(language))
            {
                langName.Add(language, new List<string>());
            }
            
                langName[language].Add(name);

            result = langName;
            return result;

        }
        static Dictionary<string,int> AddPoints(Dictionary<string,int> nameResult,string name,int points)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            if (!nameResult.ContainsKey(name))
            {
                nameResult.Add(name, points);
            }
            else
            {
                if (nameResult[name] < points)
                {
                    nameResult[name] = points;
                }
            }
            result = nameResult;
            return result;
        }
        static Dictionary<string,int> BanUser(Dictionary<string,int>nameResult,string name)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            if (nameResult.ContainsKey(name))
            {
                nameResult.Remove(name);
            }

            result = nameResult; 
            return result;
        }
    }
}
