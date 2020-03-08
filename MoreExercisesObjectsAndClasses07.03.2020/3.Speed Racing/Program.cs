using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Speed_Racing
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').Select(s => s.Trim()).ToArray();
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelPerKilometer = double.Parse(input[2]);
                
                Car car = new Car();
                car.Model = model;
                car.FuelAmount = fuelAmount;
                car.FuelPerKilometer = fuelPerKilometer;
                car.TraveledDistance = 0;

                cars.Add(car);

            }
            string command = Console.ReadLine();
            while (command!="End")
            {
                string[] splittedCommand = command.Split(' ').Select(s => s.Trim()).ToArray();
                string model = splittedCommand[1];
                double amountKm = double.Parse(splittedCommand[2]);

                for (int i = 0; i < cars.Count; i++)
                {
                    if (cars[i].Model==model)
                    {
                        cars[i].Drive(amountKm);
                    }
                }

               


                command = Console.ReadLine();

            }
           
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TraveledDistance}");
            }
        }
    }
    class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelPerKilometer { get; set; }
        public double TraveledDistance { get; set; }
        public Car()
        {

        }
        public void Drive(double kilometers)
        {
            if (this.FuelAmount < kilometers * this.FuelPerKilometer)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                this.FuelAmount -= kilometers * this.FuelPerKilometer;
                this.TraveledDistance += kilometers;
            }
        }

    }
}
