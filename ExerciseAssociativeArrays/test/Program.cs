using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i;
            //if (int.TryParse(s, out i)) return i;
            //return null;
            string goko = "12";
            bool canParse;
            int dib;
            canParse = int.TryParse(goko, out dib);
            if (canParse)
            {
                Console.WriteLine(dib);
            }
            
        }
    }
}
