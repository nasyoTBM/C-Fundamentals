using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] names = input.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string info = Console.ReadLine(); 
            Dictionary<string, int> list = new Dictionary<string, int>();
            foreach (var name in names)
            {
                list.Add(name, 0);
            }

            string pattern = @"([A-Za-z\d])";
            while (info != "end of race")
            {
                MatchCollection codes = Regex.Matches(info, pattern);
                string name = "";
                int distance = 0;
                foreach (Match match in codes)
                {
                    for (int i = 0; i < match.Value.Length; i++)
                    {
                        if (char.IsLetter(match.Value[i]))
                        {
                            name += match.Value[i];
                        }
                        else if (char.IsDigit(match.Value[i]))
                        
                        {
                            distance += (int)match.Value[i]-48;
                        }
                    }
                   
                }
                FillList(list, name, distance);
                info = Console.ReadLine();
            }
            List<string> sortedResult = new List<string>();
            foreach (var item in list.OrderByDescending(s=>s.Value))
            {
                sortedResult.Add(item.Key);
            }
           
                Console.WriteLine($"1st place: {sortedResult[0]}");
                Console.WriteLine($"2nd place: {sortedResult[1]}");
            Console.WriteLine($"3rd place: {sortedResult[2]}");


        }
        static void FillList(Dictionary<string,int> list,string name,int distance)
        {
            if (!list.ContainsKey(name))
            {
                
            }
            else
            {
                list[name] += distance;
            }
        }
    }
}
