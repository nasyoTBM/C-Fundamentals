using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.OrderByAge
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<Person> persons = new List<Person>();
            while (input!="End")
            {
                string[] splitted = input.Split(' ').Select(s => s.Trim()).ToArray();
                Person person = new Person(splitted[0],splitted[1],int.Parse(splitted[2]));
                persons.Add(person);
                input = Console.ReadLine();

            }
            
            persons.Sort((a, b) => a.Age.CompareTo(b.Age));
            foreach (var person in persons)
            {
                
                Console.WriteLine($"{person.Name} with ID: {person.Identification} is {person.Age} years old.");
            }
        }
    }
    class Person
    {
        public string Name { get; set; }
        public string Identification { get; set; }
        public int Age { get; set; }
        public Person(string name,string identification,int age)
        {
            Name = name;
            Identification = identification;
            Age = age;

        }
    }
}
