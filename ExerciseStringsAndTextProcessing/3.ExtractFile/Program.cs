using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            int last = input.GetUpperBound(0);
            string[] file = input[last].Split(new char[] { '.' }, StringSplitOptions.None).ToArray();
            Console.WriteLine($"File name: {file[0]}");
            Console.WriteLine($"File extension: {file[1]}");          

        }
    }
}
