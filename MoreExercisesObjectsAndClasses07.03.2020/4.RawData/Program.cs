using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.RawData
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
                Engine engine = new Engine();
                Cargo cargo = new Cargo();
                engine.Speed = int.Parse(input[1]);
                engine.Power = int.Parse(input[2]);
                cargo.Weight = int.Parse(input[3]);
                cargo.Type = input[4];
                Car car = new Car(input[0], engine, cargo);
                cars.Add(car);
            }
            string cargoType = Console.ReadLine();
            foreach (var car in cars)
            {
                car.PrintCar(cargoType);
            }
        }
    }
    class Cargo
    {
        public int Weight { get; set; }
        public string Type { get; set; }

    }
    class Engine
    {
        public int Speed { get; set; }
        public int Power { get; set; }
    }
    class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Car(string model, Engine engine, Cargo cargo)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
        }
        public void PrintCar(string cargoType)
        {

            if (this.Cargo.Type == cargoType)
            {
                if (cargoType == "fragile" && this.Cargo.Weight < 1000)
                {
                    Console.WriteLine(this.Model);
                }
                else if (cargoType == "flamable" && this.Engine.Power > 250)
                {
                    Console.WriteLine(this.Model);
                }
            }
        }

    }
}
