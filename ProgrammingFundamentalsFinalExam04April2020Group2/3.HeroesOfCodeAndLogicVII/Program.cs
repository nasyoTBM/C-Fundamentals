using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.HeroesOfCodeAndLogicVII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Hero> heroesList = new List<Hero>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string heroName = input[0];
                int hp = int.Parse(input[1]);
                int mp = int.Parse(input[2]);
                Hero hero = new Hero(heroName, hp, mp);
                heroesList.Add(hero);
            }
            string command = Console.ReadLine();
            while (command!="End")
            {
                string[] actions = command.Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = actions[1];
                int current = GetCurrentHeroIndex(name, heroesList);
                if (actions[0]=="CastSpell")
                {
                    
                    
                    int neededMp = int.Parse(actions[2]);
                    string spellName = actions[3];
                    


                    if (heroesList[current].MP>=neededMp)
                    {
                        heroesList[current].MP -= neededMp;
                        Console.WriteLine($"{heroesList[current].Name} has successfully cast {spellName} and now has {heroesList[current].MP} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroesList[current].Name} does not have enough MP to cast {spellName}!");
                    }
                }
                if (actions[0]=="TakeDamage")
                {
                    int damage = int.Parse(actions[2]);
                    string attacker = actions[3];
                    heroesList[current].HP -= damage;
                    if (heroesList[current].HP>0)
                    {
                        Console.WriteLine($"{heroesList[current].Name} was hit for {damage} HP by {attacker} and now has {heroesList[current].HP} HP left!");
                    }
                    else
                    {
                        heroesList.RemoveAt(current);
                        Console.WriteLine($"{name} has been killed by {attacker}!");
                    }
                }
                if (actions[0]=="Recharge")
                {
                    int amount = int.Parse(actions[2]);
                    
                    if (heroesList[current].MP + amount > 200)
                    {
                        amount = 200 - heroesList[current].MP;
                        heroesList[current].MP = 200;
                        Console.WriteLine($"{name} recharged for {amount} MP!");
                    }
                    else
                    {
                        heroesList[current].MP += amount;
                        Console.WriteLine($"{name} recharged for {amount} MP!");
                    }
                    
                }
                if (actions[0]=="Heal")
                {
                    int amount = int.Parse(actions[2]);
                    if (heroesList[current].HP + amount > 100)
                    {
                        amount = 100 - heroesList[current].HP;
                        heroesList[current].HP = 100;
                        Console.WriteLine($"{name} healed for {amount} HP!");
                    }
                    else
                    {
                        heroesList[current].HP += amount;
                        Console.WriteLine($"{name} healed for {amount} HP!");
                    }

                }
                command = Console.ReadLine();
            }

            foreach (var Hero in heroesList.OrderByDescending(s=>s.HP).ThenBy(s=>s.Name))
            {
                Console.WriteLine(Hero.Name);
                Console.WriteLine($"  HP: {Hero.HP}");
                Console.WriteLine($"  MP: {Hero.MP}");
            }

        }
        static int GetCurrentHeroIndex(string name,List<Hero> heroesList)
        {
            int currentIndex = 0;
            for (int i = 0; i < heroesList.Count; i++)
            {
                if (heroesList[i].Name == name)
                {
                    currentIndex = i;
                }
            }
            return currentIndex;
        }
    }
    class Hero
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public Hero(string name,int hp,int mp)
        {
            this.Name = name;
            this.HP = hp;
            this.MP = mp;
        }
    }
}
