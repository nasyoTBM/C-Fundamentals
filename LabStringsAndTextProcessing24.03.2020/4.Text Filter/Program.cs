using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banList = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).ToArray();
            string textToEdit = Console.ReadLine();

            foreach (var word in banList)
            {
                while (textToEdit.Contains(word))
                {
                   textToEdit = textToEdit.Replace(word, new string('*', word.Length));
                }
            }
            Console.WriteLine(textToEdit);
        }
    }
}
