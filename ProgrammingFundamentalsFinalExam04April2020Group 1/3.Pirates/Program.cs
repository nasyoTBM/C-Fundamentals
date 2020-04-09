using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int[]> cities = new Dictionary<string, int[]>();
            while (input!="Sail")
            {
                string[] command = input.Split(new string[] { "||" }, StringSplitOptions.None).ToArray();
                string cityName = command[0];
                int population = int.Parse(command[1]);
                int gold = int.Parse(command[2]);
                if (!cities.ContainsKey(cityName))
                {
                    cities.Add(cityName, new int[2]);
                    cities[cityName][0] = population;
                    cities[cityName][1] = gold;
                }
                else
                {
                    cities[cityName][0] += population;
                    cities[cityName][1] += gold;
                }

                input = Console.ReadLine();
            }
            string nextInput = Console.ReadLine();
            while (nextInput!="End")
            {
                string[] commands = nextInput.Split(new string[] { "=>" }, StringSplitOptions.None).ToArray();
                string cityName = commands[1];

                if (commands[0]=="Plunder")
                {
                    int population = int.Parse(commands[2]);
                    int gold = int.Parse(commands[3]);
                    Console.WriteLine($"{cityName} plundered! {gold} gold stolen, {population} citizens killed.");
                    cities[cityName][0] -= population;
                    cities[cityName][1] -= gold;
                    if (cities[cityName][0]<=0 || cities[cityName][1]<=0)
                    {
                        Console.WriteLine($"{cityName} has been wiped off the map!");
                        cities.Remove(cityName);
                    }
                }
                else if(commands[0]=="Prosper")
                {
                   
                    int gold = int.Parse(commands[2]);

                    if (gold<0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        cities[cityName][1] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {cityName} now has {cities[cityName][1]} gold.");
                    }
                }
                



                nextInput = Console.ReadLine();
            }
            if (cities.Count!=0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                foreach (var city in cities.OrderByDescending(s => s.Value[1]).ThenBy(s => s.Key))
                {

                    Console.WriteLine($"{city.Key} -> Population: {city.Value[0]} citizens, Gold: {city.Value[1]} kg");



                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            
        }
    }
}
