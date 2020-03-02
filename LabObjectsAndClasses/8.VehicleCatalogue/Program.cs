using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.VehicleCatalogue
{
    class Truck
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public int Weight { get; set; }

    }
    class Car
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public int HorsePower { get; set; }

    }
    class Catalogue
    {
        public Catalogue(List<Car> cars, List<Truck> trucks)
        {
            Cars = cars;
            Trucks = trucks;
        }
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            Catalogue catalogue = new Catalogue(cars, trucks);

            while (input != "end")
            {
                string[] inputToArray = input.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string type = inputToArray[0];
                string brand = inputToArray[1];
                string model = inputToArray[2];
                int horsePowerOrWeight = int.Parse(inputToArray[3]);
                Car car = new Car();
                Truck truck = new Truck();

                if (type == "Car")
                {
                    car.Brand = brand;
                    car.Model = model;
                    car.HorsePower = horsePowerOrWeight;
                    catalogue.Cars.Add(car);
                }
                else if (type == "Truck")
                {
                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weight = horsePowerOrWeight;
                    catalogue.Trucks.Add(truck);
                }
                input = Console.ReadLine();
            }
            if (catalogue.Cars.Count != 0)
            {
                Console.WriteLine("Cars:");
                foreach (var car in catalogue.Cars.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }

            }
            if (catalogue.Trucks.Count != 0)
            {
                Console.WriteLine("Trucks:");
                foreach (var truck in catalogue.Trucks.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}
