using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Rankings
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contestPw = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> monaLisa = new Dictionary<string, Dictionary<string, int>>();

            string n = Console.ReadLine();
            while (n!= "end of contests")
            {
                string[] input = n.Split(new char[] { ':' }, StringSplitOptions.None).ToArray();
                string contestName = input[0];
                string contestPassword = input[1];
                contestPw.Add(contestName, contestPassword);
                n = Console.ReadLine();
            }
            n = Console.ReadLine();
            while (n != "end of submissions")
            {
                string[] input = n.Split(new string[] { "=>" }, StringSplitOptions.None).ToArray();
                string contestName = input[0];
                string contestPassword = input[1];
                string userName = input[2];
                int userPoints = int.Parse(input[3]);
                AddUser(contestPw, monaLisa, userName, userPoints, contestName, contestPassword);
                n = Console.ReadLine();

            }
            int totalSum = 0;
            string winner = string.Empty;

            foreach (var item in monaLisa)
            {
                int eachUserPoints = 0;
                
                foreach (var itm in item.Value)
                {
                    eachUserPoints += itm.Value;
                }
                if (eachUserPoints>totalSum)
                {
                    totalSum = eachUserPoints;
                    winner = item.Key;
                }
            }
            Console.WriteLine($"Best candidate is {winner} with total {totalSum} points.");
            Console.WriteLine("Ranking: ");
            foreach (var item in monaLisa.OrderBy(s=>s.Key))
            {
                Console.WriteLine(item.Key);

                foreach (var itm in item.Value.OrderByDescending(s=>s.Value))
                {
                    Console.WriteLine($"#  {itm.Key} -> {itm.Value}");
                }
               
            }


        }
        static Dictionary<string, Dictionary<string, int>> AddUser(Dictionary<string, string> contestPw,Dictionary<string, Dictionary<string, int>> res, string userName, int userPoints,string contestName,string contestPassword)
        {
            Dictionary<string, Dictionary<string,int>> result = new Dictionary<string, Dictionary<string, int>>();
            bool access = false;
            
            if (contestPw.ContainsKey(contestName))
            {
                if (contestPw[contestName].Contains(contestPassword))
                {
                    access = true;
                    
                }
            }
            if (access)
            {
                if (!res.ContainsKey(userName))
                {
                    res.Add(userName, new Dictionary<string, int>());
                    res[userName].Add(contestName, userPoints);

                }
                if (!res[userName].ContainsKey(contestName))
                {
                    res[userName].Add(contestName, userPoints);
                }
                else
                {
                    if (userPoints > res[userName][contestName])
                    {
                        res[userName][contestName] = userPoints;
                    }
                }
            }
            result = res;
            return result;
        }
    }
}
