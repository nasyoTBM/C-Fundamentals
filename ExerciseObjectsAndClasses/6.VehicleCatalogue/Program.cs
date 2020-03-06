using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.VehicleCatalogue
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            while (input != "End")
            {
                string[] vehicles = input.Split(' ').Select(s => s.Trim()).ToArray();
                string type = vehicles[0];
                string model = vehicles[1];
                string color = vehicles[2];
                int horsePower = int.Parse(vehicles[3]);
                Car car = new Car();
                Truck truck = new Truck();
                if (type == "car")
                {

                    car.Model = model;
                    car.Color = color;
                    car.HorsePower = horsePower;
                    cars.Add(car);
                }
                else if (type == "truck")
                {

                    truck.Model = model;
                    truck.Color = color;
                    truck.HorsePower = horsePower;
                    trucks.Add(truck);
                }
                input = Console.ReadLine();

            }
            VehicleCatalogue catalogue = new VehicleCatalogue(cars, trucks);
            string request = Console.ReadLine();
            while (request != "Close the Catalogue")
            {

                if (catalogue.Cars.Any(s => s.Model == request))
                {
                    int index = catalogue.Cars.FindIndex(x => x.Model == request);
                    Console.WriteLine($"Type: {catalogue.Cars[index].Type}");
                    Console.WriteLine($"Model: {catalogue.Cars[index].Model}");
                    Console.WriteLine($"Color: {catalogue.Cars[index].Color}");
                    Console.WriteLine($"Horsepower: {catalogue.Cars[index].HorsePower}");

                }
                else if (catalogue.Trucks.Any(s => s.Model == request))
                {
                    int index = catalogue.Trucks.FindIndex(x => x.Model == request);
                    Console.WriteLine($"Type: {catalogue.Trucks[index].Type}");
                    Console.WriteLine($"Model: {catalogue.Trucks[index].Model}");
                    Console.WriteLine($"Color: {catalogue.Trucks[index].Color}");
                    Console.WriteLine($"Horsepower: {catalogue.Trucks[index].HorsePower}");
                }

                request = Console.ReadLine();

            }
            if (catalogue.Cars.Count!=0)
            {
                Console.WriteLine($"Cars have average horsepower of: {catalogue.AverageHorsePowerCars():F2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: 0.00.");
            }
            if (catalogue.Trucks.Count!=0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {catalogue.AverageHorsePowerTrucks():F2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: 0.00.");
            }
           
                
            
        }
    }
    class Car
    {
        public string Type = "Car";
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }


    }
    class Truck
    {
        public string Type = "Truck";
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }


    }
    class VehicleCatalogue
    {
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
        public VehicleCatalogue(List<Car> cars, List<Truck> trucks)
        {
            Cars = cars;
            Trucks = trucks;
        }
        public double AverageHorsePowerCars()
        {
            double total = 0;
            for (int i = 0; i < Cars.Count; i++)
            {
                total += Cars[i].HorsePower;
            }
            return total / Cars.Count;

        }
        public double AverageHorsePowerTrucks()
        {
            double total = 0;
            for (int i = 0; i < Trucks.Count; i++)
            {
                total += Trucks[i].HorsePower;
            }
            return total / Trucks.Count;

        }

    }
}
