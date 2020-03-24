using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.SnowWhite
{
    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> dwarfs = new Dictionary<string, Dictionary<string, int>>();
            string n = Console.ReadLine();
            while (n != "Once upon a time")
            {
                string[] input = n.Split(new string[] { " <:> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string dwarfName = input[0];
                string dwarfColor = input[1];
                int dwarfPhysics = int.Parse(input[2]);
                StoreDwarfs(dwarfs, dwarfName, dwarfColor, dwarfPhysics);

                n = Console.ReadLine();

            }
            PrintDwarfs(dwarfs);
        }


        static Dictionary<string, Dictionary<string, int>> StoreDwarfs(Dictionary<string, Dictionary<string, int>> dwarfs, string name, string color, int physics)
        {

            

            Dictionary<string, Dictionary<string, int>> result = new Dictionary<string, Dictionary<string, int>>();
            if (!dwarfs.ContainsKey(color))
            {
                dwarfs.Add(color, new Dictionary<string, int>());
                dwarfs[color].Add(name, physics);
            }
            else if (!dwarfs[color].ContainsKey(name))
            {
                dwarfs[color].Add(name, physics);
            }
            else if (dwarfs[color][name] < physics)
            {
                dwarfs[color][name] = physics;
            }


            result = dwarfs;
            return result;
        }
        static void PrintDwarfs(Dictionary<string, Dictionary<string, int>> dwarfs)
        {
            //You must order the dwarfs by physics in descending order and then by total count of dwarfs with the same hat color in descending order. 





        }
    }
}
