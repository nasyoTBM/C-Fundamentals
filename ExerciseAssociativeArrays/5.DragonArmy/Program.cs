using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<Dragon>> dragons = new Dictionary<string, List<Dragon>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string type = input[0];
                string name = input[1];
                string damage = input[2];
                string health = input[3];
                string armor = input[4];
                Dragon dragon = new Dragon(name, damage, health, armor);

                AddDragon(dragons, type, dragon);
            }
            
            foreach (var item in dragons)
            {
                double avDmg = item.Value.Select(x => x.Damage).Average();
                double avHp = item.Value.Select(x => x.Health).Average();
                double avArmor = item.Value.Select(x => x.Armor).Average();

                Console.WriteLine($"{item.Key}::({avDmg:f2}/{avHp:f2}/{avArmor:f2})");

                

                foreach (var itmm in item.Value.OrderBy(s=>s.Name))
                {
                    Console.WriteLine($"-{itmm.Name} -> damage: {itmm.Damage}, health: {itmm.Health}, armor: {itmm.Armor}");
                }
            }


        }
        static Dictionary<string, List<Dragon>> AddDragon(Dictionary<string, List<Dragon>> dragons, string type, Dragon dragon)
        {
            Dictionary<string, List<Dragon>> result = new Dictionary<string, List<Dragon>>();
            
            if (dragons.ContainsKey(type))
            {
                
                if (dragons[type].Any(s => s.Name.Contains(dragon.Name)))
                {
                    int index = 0;
                    index = dragons[type].FindIndex(s => s.Name.Contains(dragon.Name));
                    dragons[type].RemoveAt(index);
                    dragons[type].Add(dragon);
                }
                else
                {
                    dragons[type].Add(dragon);
                }
                
            }
            else
            {
                dragons.Add(type, new List<Dragon>());
                dragons[type].Add(dragon);
            }
            result = dragons;
            return result;
        }
    }
    class Dragon
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }

        public Dragon(string name,string damage,string health,string armor)
        {
            this.Name = name;

            if (damage=="null")
            {
                this.Damage = 45;
            }
            else
            {
                this.Damage = int.Parse(damage);
            }
            if (health=="null")
            {
                this.Health = 250;
            }
            else
            {
                this.Health = int.Parse(health);
            }
            if (armor == "null")
            {
                this.Armor = 10;
            }
            else
            {
                this.Armor = int.Parse(armor);
            }
            
         }
        
    }
}
