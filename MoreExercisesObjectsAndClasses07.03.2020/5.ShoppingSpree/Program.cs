using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputPersons = Console.ReadLine().Split(new char[] { ';' },StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<Product> products = new List<Product>();
            List<Person> persons = new List<Person>();

            foreach (string item in inputPersons)
            {
                string[] splitted = item.Split('=').Select(s => s.Trim()).ToArray();
                string name = splitted[0];
                double money = double.Parse(splitted[1]);
                Person person = new Person();
                person.Name = name;
                person.Money = money;
                persons.Add(person);
            }
            string[] inputProducts = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach (string item in inputProducts)
            {
                string[] splitted = item.Split('=').Select(s => s.Trim()).ToArray();
                string name = splitted[0];
                double cost = double.Parse(splitted[1]);
                Product product = new Product();
                product.Name = name;
                product.Cost = cost;
                products.Add(product);
                
            }
            string inp = Console.ReadLine();
            
            while (inp!="END")
            {
                string[] input = inp.Split(' ').Select(s => s.Trim()).ToArray();
                foreach (var person in persons.Where(s => s.Name == input[0]))
                {
                    foreach (var item in products.Where(s => s.Name == input[1]))
                    {
                        person.BuyingProduct(item);
                    }
                }
                inp = Console.ReadLine();

            }
            foreach (var person in persons)
            {
                person.PrintPersons();
            }
            

        }
    }
    class Person
    {
        public string Name { get; set; }
        public double Money { get; set; }
        public List<Product> ProductsBag { get; set; }
        public Person()
        {
            ProductsBag = new List<Product>();
        }
        public void BuyingProduct(Product product)
        {
            if (this.Money >= product.Cost)
            {
                Console.WriteLine($"{this.Name} bought {product.Name}");
                ProductsBag.Add(product);
                this.Money -= product.Cost;
            }
            else
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }
        }
        public void PrintPersons()
        {
            if (this.ProductsBag.Count==0)
            {
                Console.WriteLine($"{this.Name} - Nothing bought");
            }
            else
            {
                Console.WriteLine($"{this.Name} - {string.Join(", ",this.ProductsBag.Select(s=>s.Name))}");
            }
        }
    }
    class Product
    {
        public string Name { get; set; }
        public double Cost { get; set; }
    }
}
