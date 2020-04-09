using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.NikuldensMeals
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            string input = Console.ReadLine();
            Dictionary<string, List<string>> mealBook = new Dictionary<string, List<string>>();
            while (input!="Stop")
            {
                string[] commands = input.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = commands[0];
                string guest = commands[1];
                string meal = commands[2];
                if (command == "Like")
                {
                    Like(mealBook, guest, meal);
                }
                else if (command == "Unlike")
                {

                    if (!mealBook.ContainsKey(guest))
                    {
                        Console.WriteLine($"{guest} is not at the party.");
                    }
                    else if (!mealBook[guest].Contains(meal))
                    {
                        Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                    }
                    else if (mealBook.ContainsKey(guest) && mealBook[guest].Contains(meal))
                    {
                        mealBook[guest].Remove(meal);
                        Console.WriteLine($"{guest} doesn't like the {meal}.");
                        result++;
                    }
                }
                
                
                input = Console.ReadLine();
            }
            foreach (var guest in mealBook.OrderByDescending(s=>s.Value.Count).ThenBy(s=>s.Key))
            {
                Console.WriteLine($"{guest.Key}: {string.Join(", ",guest.Value)}");
            }
            Console.WriteLine($"Unliked meals: {result}");
        }
        static void Like(Dictionary<string,List<string>> mealBook,string guest,string meal)
        {
            if (!mealBook.ContainsKey(guest))
            {
                mealBook.Add(guest, new List<string>());
                mealBook[guest].Add(meal);
            }
            if (!mealBook[guest].Contains(meal))
            {
                mealBook[guest].Add(meal);
            }
        }
       
           
            
        
    }
}
