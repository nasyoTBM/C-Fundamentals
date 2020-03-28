using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.TreasureFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] keys = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string n = Console.ReadLine();
            while (n!="find")
            {

                string command = DecodeString(n,FillKeys(keys,n.Length));

                PrintResult(command);
                n = Console.ReadLine();
            }
        }
        static int[] FillKeys(int[] keys,int length)
        {
            int[] result = new int[length];
            int index = 0;
            for (int i = 0; i < result.Length; i++)
            {
                if (index >= keys.Length)
                {
                    index = 0; 
                }
                result[i] = keys[index++];
            }
            return result;
        }
        static string DecodeString(string input,int[] keys)
        {
            string sb = "";
            for (int i = 0; i < input.Length; i++)
            {
                int current = (int)input[i];
                sb += (char)(current - keys[i]);
                
            }
            return sb;
        }
        static void PrintResult(string command)
        {
            int itemStart = command.IndexOf('&')+1;
            int itemEnd = command.IndexOf('&', command.IndexOf('&') + 1);
            itemEnd -= itemStart;
            string item = command.Substring(itemStart, itemEnd);
            int locationStart = command.IndexOf('<')+1;
            int locationEnd = command.IndexOf('>');
            locationEnd -= locationStart;
            string itemLocation = command.Substring(locationStart, locationEnd);
            Console.WriteLine($"Found {item} at {itemLocation}");
        }
    }
}
