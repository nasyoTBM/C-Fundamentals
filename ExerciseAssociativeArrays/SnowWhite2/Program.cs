using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowWhite2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,List<Dwarf>> listDwarfs = new Dictionary<string,List<Dwarf>>();
            string n = Console.ReadLine();

            while (n!="Once upon a time")
            {
                string[] input = n.Split(new string[] { " <:> " }, StringSplitOptions.None).ToArray();

                string dwarfName = input[0];
                string color = input[1];
                int dwarfPhysics = int.Parse(input[2]);
                

                Dwarf dwarf = new Dwarf(dwarfName, dwarfPhysics);

                if (!listDwarfs.ContainsKey(color))
                {
                    listDwarfs.Add(color, new List<Dwarf>());
                    listDwarfs[color].Add(dwarf);
                    
                }
                else if (!listDwarfs[color].Any(s=>s.Name==dwarfName))
                {
                    listDwarfs[color].Add(dwarf);
                    
                }
                else
                {
                    if (listDwarfs[color].Any(s => s.Name == dwarfName))
                    {
                        int index = 0;
                        index = listDwarfs[color].FindIndex(s => s.Name == dwarfName);
                        listDwarfs[color][index].Physics = dwarfPhysics;
                    }
                    
                }
               
                
                n = Console.ReadLine();
            }

            // sort by physics
            Console.WriteLine("BEFORE");
            foreach (var dwarf in listDwarfs)
            {
                foreach (var item in dwarf.Value)
                {
                    Console.WriteLine($"({dwarf.Key}) {item.Name} <-> {item.Physics}");
                }
            }
            foreach (var key in listDwarfs.Keys)
            {
                var dwarfs = listDwarfs[key];
                dwarfs.OrderByDescending(i => i.Physics).ToList();
                var d = 5;
            }
            Console.WriteLine("AFTER");
            foreach (var dwarf in listDwarfs)
            {
                foreach (var item in dwarf.Value)
                {
                    Console.WriteLine($"({dwarf.Key}) {item.Name} <-> {item.Physics}");
                }
            }
            //listDwarfs.OrderByDescending(i => {
            //    var dwarfs = listDwarfs[i.Key];

            //});

            //listDwarfs.OrderByDescending(i => { i.Value.OrderByDescending(i => i.Physics)});

            List<Dictionary<string, Dwarf>> dl = new List<Dictionary<string, Dwarf>>();
            //dl.OrderByDescending(i => i.Values.)

            listDwarfs.OrderByDescending(d => d.Value.Count);
            foreach (var dwarf in listDwarfs)
            {
                foreach (var item in dwarf.Value)
                {
                    Console.WriteLine($"({dwarf.Key}) {item.Name} <-> {item.Physics}");
                }
            }

            var d = new Dwarf();
            d.Name = " SHUT";
            d.Physics = 1;


            List<Dwarf> dwarves = new List<Dwarf>() { 
                new Dwarf { Name = "name1", Physics = 1 },
                new Dwarf { Name = "name2", Physics = 2 }
};
            



           
        }
    }
    
    class Dwarf
    {
        
        public string Name { get; set; }
        public int Physics { get; set; }
        //public Dwarf(string name,int physics)
        //{
           
        //    this.Name = name;
        //    this.Physics = physics;
        //}
    }
}
