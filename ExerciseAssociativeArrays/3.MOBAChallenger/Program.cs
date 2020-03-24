using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.MOBAChallenger
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string n = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> workWith = new Dictionary<string, Dictionary<string, int>>();
            while (n != "Season end")
            {
                if (n.Contains("->"))
                {
                    string[] input = n.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string playerName = input[0];
                    string position = input[1];
                    int skillPoints = int.Parse(input[2]);
                    AddtoPlayersPool(workWith, playerName, position, skillPoints);
                }
                else if (n.Contains("vs"))
                {
                    string[] input = n.Split(new string[] { " vs " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string playerOne = input[0];
                    string playerTwo = input[1];
                    PlayersDuel(workWith, playerOne, playerTwo);
                }
                n = Console.ReadLine();
            }
            
            foreach (var item in workWith.OrderByDescending(s=>s.Value.Sum(x=>x.Value)).ThenBy(s=>s.Key))
            {
                
                Console.WriteLine(item.Value.Sum(x=>x.Value));
                foreach (var itm in item.Value.OrderByDescending(s=>s.Value).ThenBy(s=>s.Key))
                {
                    
                    Console.WriteLine(itm.Key+ " <:::> " + itm.Value);
                }
            }

        }
        static Dictionary<string, Dictionary<string, int>> AddtoPlayersPool(Dictionary<string, Dictionary<string, int>> workWith, string playerName, string position, int skillPoints)
        {
            Dictionary<string, Dictionary<string, int>> result = new Dictionary<string, Dictionary<string, int>>();
            if (!workWith.ContainsKey(playerName))
            {
                workWith.Add(playerName, new Dictionary<string, int>());
                workWith[playerName].Add(position, skillPoints);
            }
            else if (!workWith[playerName].ContainsKey(position))
            {
                workWith[playerName].Add(position, skillPoints);
            }
            else if (workWith[playerName][position] < skillPoints)
            {
                workWith[playerName][position] = skillPoints;
            }
            result = workWith;
            return result;
        }
        static Dictionary<string, Dictionary<string, int>> PlayersDuel(Dictionary<string, Dictionary<string, int>> workWith, string playerOne, string playerTwo)
        {
            Dictionary<string, Dictionary<string, int>> result = new Dictionary<string, Dictionary<string, int>>();
            string equalPosition = string.Empty;
            bool isEqual = false;
            if (workWith.ContainsKey(playerOne) && workWith.ContainsKey(playerTwo))
            {
                foreach (var item in workWith[playerOne])
                {
                    foreach (var itm in workWith[playerTwo])
                    {
                        if (item.Key == itm.Key)
                        {
                            equalPosition = item.Key;
                            isEqual = true;
                        }
                    }
                }
            }
            if (isEqual)
            {
                if (workWith[playerOne][equalPosition] > workWith[playerTwo][equalPosition])
                {
                    workWith.Remove(playerTwo);
                }
                else if (workWith[playerTwo][equalPosition] > workWith[playerOne][equalPosition])
                {
                    workWith.Remove(playerOne);
                }
            }
            result = workWith;
            return result;
        }

    }
}
