using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach (var item in input)
            {
                bool isValid = false;
                if (item.Length >= 3 && item.Length <= 16)
                {
                    isValid = true;
                }
                
                foreach (var itm in item)
                {

                    if (isValid==true)
                    {
                        if (char.IsLetterOrDigit(itm) || itm == '-' || itm == '_')
                        {
                            isValid = true;
                        }
                        else
                        {
                            isValid = false;
                        }
                    }
                    
                }
                if (isValid)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
