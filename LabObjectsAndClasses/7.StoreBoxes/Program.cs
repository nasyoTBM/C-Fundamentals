using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.StoreBoxes
{
    public class Item
    {
        public Item(string name, decimal price)
        {
            Price = price;
            Name = name;
        }
        public decimal Price { get; set; }
        public string Name { get; set; }
    }
    public class Box
    {
        public Box(string serialNumber, Item item, int itemQuantity)
        {
            SerialNumber = serialNumber;
            Item = item;
            ItemQuantity = itemQuantity;
        }
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceForABox { get { return Item.Price * ItemQuantity; } }

        //=> Item.Price * ItemQuantity;
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Box> boxes = new List<Box>();
            while (input != "end")
            {
                string[] inputToArray = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string serialNumber = inputToArray[0];
                string name = inputToArray[1];
                int quantity = int.Parse(inputToArray[2]);
                decimal price = decimal.Parse(inputToArray[3]);

                Item item = new Item(name, price);
                Box box = new Box(serialNumber, item, quantity);
                boxes.Add(box);

                input = Console.ReadLine();

            }
            foreach (var box in boxes.OrderByDescending(x => x.PriceForABox))
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForABox:F2}");

            }


        }
    }
}
