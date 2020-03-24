using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            //{ username} -> { contest} -> { points}
            string n = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> work = new Dictionary<string, Dictionary<string, int>>();
            while (n != "no more time")
            {
                string[] input = n.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string userName = input[0];
                string contestName = input[1];
                int userPoints = int.Parse(input[2]);
                if (!work.ContainsKey(contestName))
                {
                    work.Add(contestName, new Dictionary<string, int>());
                    work[contestName].Add(userName, userPoints);
                }
                
                else if (!work[contestName].ContainsKey(userName))
                    {
                        work[contestName].Add(userName, userPoints);
                    }
                else if (work[contestName][userName] < userPoints)
                    {
                        work[contestName][userName] = userPoints;
                    }
                    
                
                n = Console.ReadLine();
            }
            Dictionary<string, int> totalScores = new Dictionary<string, int>();

            foreach (var item in work)
            {
                foreach (var itm in item.Value)
                {
                    if (!totalScores.ContainsKey(itm.Key))
                    {
                        totalScores.Add(itm.Key, itm.Value);
                    }
                    else
                    {
                        totalScores[itm.Key] += itm.Value;
                    }
                }
            }

            foreach (var item in work)
            {
                int position = 1;
                Console.WriteLine($"{item.Key}: {item.Value.Count} participants");
                
                foreach (var itm in item.Value.OrderByDescending(s=>s.Value).ThenBy(s=>s.Key))
                {
                    Console.WriteLine($"{position}. {itm.Key} <::> {itm.Value}");
                    position++;
                }
            }
            Console.WriteLine("Individual standings: ");
            int pos = 1;
            foreach (var item in totalScores.OrderByDescending(s=>s.Value).ThenBy(s=>s.Key))
            {
                
                Console.WriteLine($"{pos}. {item.Key} -> {item.Value}");
                pos++;
            }

        }
    }
}
