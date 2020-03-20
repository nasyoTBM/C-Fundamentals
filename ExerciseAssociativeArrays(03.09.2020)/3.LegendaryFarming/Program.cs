using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyItems = new Dictionary<string, int>();
            keyItems.Add("motes", 0);
            keyItems.Add("shards", 0);
            keyItems.Add("fragments", 0);
            Dictionary<string, int> junkItems = new Dictionary<string, int>();
            string inp = Console.ReadLine().ToLower();
            bool ready = false;

            while (true)
            {
                string[] input = inp.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int i = 1; i < input.Length; i++)
                {

                    if (input[i] == "motes" || input[i] == "fragments" || input[i] == "shards")
                    {
                        AddKeyItems(keyItems, input[i], int.Parse(input[i - 1]));
                        if (keyItems.ContainsKey("motes") && keyItems["motes"] >= 250)
                        {
                            Console.WriteLine("Dragonwrath obtained!");
                            keyItems["motes"] -= 250;
                            ready = true;
                            break;
                            
                        }
                        if (keyItems.ContainsKey("shards") && keyItems["shards"] >= 250)
                        {
                            Console.WriteLine("Shadowmourne obtained!");
                            keyItems["shards"] -= 250;
                            ready = true;
                            break;
                        }
                        if (keyItems.ContainsKey("fragments") && keyItems["fragments"] >= 250)
                        {
                            Console.WriteLine("Valanyr obtained!");
                            keyItems["fragments"] -= 250;
                            ready = true;
                            break;
                        }
                    }
                    else
                    {
                        AddJunkItems(junkItems, input[i], int.Parse(input[i - 1]));
                    }
                    i++;
                }
                if (ready==true)
                {
                    break;
                }

                inp = Console.ReadLine().ToLower();
            }
            foreach (var item in keyItems.OrderByDescending(s => s.Value).ThenBy(s => s.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junkItems.OrderBy(s => s.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
        static Dictionary<string, int> AddKeyItems(Dictionary<string, int> dict, string input, int value)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            
            if (dict.ContainsKey(input))
            {
                dict[input] += value;
            }
            
            result = dict;
            return result;
        }
        static Dictionary<string, int> AddJunkItems(Dictionary<string, int> dict, string input, int value)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            if (dict.ContainsKey(input))
            {
                dict[input] += value;
            }
            else
            {
                dict.Add(input, value);
            }
            result = dict;
            return result;
        }
    }


}
