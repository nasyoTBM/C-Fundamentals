using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.InboxManager
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> userBook = new Dictionary<string, List<string>>();

            while (input!= "Statistics")
            {
                string[] command = input.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string username = command[1];

                if (command[0]=="Add")
                {
                   
                    AddUser(userBook, username);
                }
                else if (command[0] == "Send")
                {
                    string mail = command[2];
                    SendUser(userBook, username, mail);
                }
                else if (command[0] == "Delete")
                {
                    DeleteUser(userBook, username);
                }    
                

                input = Console.ReadLine();
            }
            Console.WriteLine($"Users count: {userBook.Count}");
            foreach (var user in userBook.OrderByDescending(s=>s.Value.Count).ThenBy(s=>s.Key))
            {
                Console.WriteLine(user.Key);
                foreach (var item in user.Value)
                {
                    Console.WriteLine($"- {item}");
                }

            }
        }
        static void AddUser(Dictionary<string,List<string>> userBook,string username)
        {
            if (!userBook.ContainsKey(username))
            {
                userBook.Add(username, new List<string>());
            }
            else
            {
                Console.WriteLine($"{username} is already registered");
            }
        }
        static void SendUser(Dictionary<string, List<string>> userBook, string username,string mail)
        {
            if (userBook.ContainsKey(username))
            {
                userBook[username].Add(mail);
            }
        }
        static void DeleteUser(Dictionary<string,List<string>> userBook,string username)
        {
            if (userBook.ContainsKey(username))
            {
                userBook.Remove(username);
            }
            else
            {
                Console.WriteLine($"{username} not found!");
            }
        }
    }
}
