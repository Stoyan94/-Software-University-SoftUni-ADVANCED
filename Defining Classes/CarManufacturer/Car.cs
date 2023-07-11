using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        
      

        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;

        }

        public Car(string make, string model, int year): this()
        {
            Make=make;
            Model=model;
            Year=year;
        }

        public Car(string make, string model, int year,double fuelQuantity, double fuelConsumption) : 
            this(make,model,year)
        {
            FuelQuantity= fuelQuantity;
            FuelConsumption= fuelConsumption;
        } 
        public Car(string make, string model, int year,double fuelQuantity, double fuelConsumption,
            Engine engine, Tire[] tires) : 
            this(make,model,year,fuelQuantity,fuelConsumption)
        {
            this.Engine = engine;
            this.Tiers = tires;
        }

        public string Make { get { return this.make; } set { this.make = value; } }

        public string Model { get { return this.model; } set {this.model=value; } }

        public int Year { get { return this.year; } set { this.year=value; } }

        public double FuelQuantity { get { return this.fuelQuantity; } set { this.fuelQuantity = value; } }

        public double FuelConsumption { get { return this.fuelConsumption; } set { this.fuelConsumption = value; } }

        public Engine Engine { get; set; }
        public Tire[] Tiers { get; set; }
        public void Drive(double distance)
        {
            if (fuelQuantity - ((distance * fuelConsumption) / 100)>0)
            {
                fuelQuantity -= ((distance * fuelConsumption) /100);
            }
            else
            {
                Console.WriteLine($"Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            return $"Make: {this.Make} " +
                $"Model: { this.Model} " +
                $"Year: { this.Year} " +
                $"Fuel: { this.FuelQuantity:F2}";
        }
    }
}
