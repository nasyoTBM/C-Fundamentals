using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,List<string>> output = new Dictionary<string,List<string>>();
            string input = Console.ReadLine();
            while (input!="Lumpawaroo")
            {
                
                if (input.Contains("|"))
                {
                    string[] splitted = input.Split(new string[] { " | " }, StringSplitOptions.None).ToArray();

                    string side = splitted[0];
                    string userName = splitted[1];
                    AddUsers(output, userName, side);
                }
                if (input.Contains("->"))
                {
                    string[] splitted = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string side = splitted[1];
                    string name = splitted[0];
                    AddRemoveUsers(output, name, side);
                }
                input = Console.ReadLine();

            }
            
            foreach (var item in output.OrderByDescending(s=>s.Value.Count).ThenBy(s=>s.Key).Where(s=>s.Value.Count>0))
            {
                Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");
                foreach (var items in item.Value.OrderBy(s=>s))
                {
                    Console.WriteLine($"! {items}");
                }
            }
        }
        public static Dictionary<string,List<string>> AddUsers(Dictionary<string,List<string>> input,string userName,string side)
        {
            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();

            if (!input.ContainsKey(side))
            {
                input.Add(side, new List<string>());
                if (!input.Values.Any(x=>x.Contains(userName)))
                {
                    input[side].Add(userName);
                }
                
            }
            else if (!input[side].Contains(userName))
            {
                input[side].Add(userName);
            }
            result = input;
            return result;
        }
        public static Dictionary<string, List<string>> AddRemoveUsers(Dictionary<string, List<string>> input, string userName, string side)
        {
            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();

            if (input.ContainsKey(side))
            {
                
                if (!input[side].Contains(userName))
                {
                    foreach (var item in input)
                    {
                        if (item.Value.Contains(userName))
                        {
                            item.Value.Remove(userName);
                        }
                    }
                    input[side].Add(userName);
                    Console.WriteLine($"{userName} joins the {side} side!");
                    
                }
            }
            else
            {
                foreach (var item in input)
                {
                    if (item.Value.Contains(userName))
                    {
                        item.Value.Remove(userName);
                    }
                }
                input.Add(side, new List<string>());
                input[side].Add(userName);
                Console.WriteLine($"{userName} joins the {side} side!");
            }
            result = input;
            return result;
        }
    }
}
