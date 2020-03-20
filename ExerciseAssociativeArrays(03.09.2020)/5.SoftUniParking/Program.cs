using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> register = new Dictionary<string, string>();
            
            for (int i = 0; i < n; i++)
            {
                
                string[] commands = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (commands[0]=="register")
                {
                    Register(register, commands[1], commands[2]);
                }
                if (commands[0]=="unregister")
                {
                    Unregister(register, commands[1]);
                }
                

            }
            foreach (var item in register)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
        static Dictionary<string,string> Register(Dictionary<string,string>input,string name,string numberPlate)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            if (input.ContainsKey(name))
            {
                Console.WriteLine($"ERROR: already registered with plate number {numberPlate}");
            }
            else
            {
                input.Add(name, numberPlate);
                Console.WriteLine($"{name} registered {numberPlate} successfully");
            }
            result = input;
            return result;
        }
        static Dictionary<string, string> Unregister(Dictionary<string, string> input, string name)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            if (!input.ContainsKey(name))
            {
                Console.WriteLine($"ERROR: user {name} not found");
            }
            else
            {
                input.Remove(name);
                Console.WriteLine($"{name} unregistered successfully");
            }
            result = input;
            return result;
        }
    }
    
}
