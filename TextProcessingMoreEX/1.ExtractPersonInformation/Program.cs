using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ExtractPersonInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string n = Console.ReadLine();
                Console.WriteLine($"{FindName(n)} is {FindAge(n)} years old.");


            }
            
        }
        static string FindName(string input)
        {
            int start = input.IndexOf('@')+1;
            int end = input.IndexOf('|');
            end -= start;
            string result = input.Substring(start, end);
            return result;
        }
        static int FindAge(string input)
        {
            int start = input.IndexOf('#') + 1;
            int end = input.IndexOf('*');
            end -= start;
            string age = input.Substring(start, end);
            int result = int.Parse(age);
            return result;
        }
    }
}
