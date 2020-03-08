using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.OldestFamilyMember
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Family members = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] member = Console.ReadLine().Split(' ').Select(s => s.Trim()).ToArray();
                int age = int.Parse(member[1]);
                string name = member[0];
                Person person = new Person();
                person.Name = name;
                person.Age = age;
                members.AddMember(person);

            }
            Person oldestMember = members.GetOldestMember();
            Console.WriteLine("{0} {1}", oldestMember.Name, oldestMember.Age);
        }
    }
    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }

    }
    class Family
    {
        public List<Person> persons { get; set; }
        public Family()
        {
            this.persons = new List<Person>();
        }
        
        public void AddMember(Person member)
        {
            persons.Add(member);
        }
        public Person GetOldestMember()
        {
            return this.persons.OrderByDescending(x => x.Age).First();
        }
    }
}
