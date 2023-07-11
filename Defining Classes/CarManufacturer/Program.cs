using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
     public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire[]> allTires = new List<Tire[]>();           
            List<Car> allCars = new List<Car>();
            List<Engine> allEngines = new List<Engine>();
            
            string tiers;

            while ((tiers=Console.ReadLine())!="No more tires")
            {
                var tireosInfo = tiers.Split(' ');               
                
                Tire[] currTires = new Tire[]
               {
                 new Tire(int.Parse(tireosInfo[0]), double.Parse(tireosInfo[1])),
                 new Tire(int.Parse(tireosInfo[2]), double.Parse(tireosInfo[3])),
                 new Tire(int.Parse(tireosInfo[4]), double.Parse(tireosInfo[5])),
                 new Tire(int.Parse(tireosInfo[6]), double.Parse(tireosInfo[7])),
               };

                allTires.Add(currTires);
               
            }

            string engines;

            

            while ((engines=Console.ReadLine())!= "Engines done")
            {
                var engineInfo = engines.Split(' ');

                Engine newEng = new Engine(int.Parse(engineInfo[0]),double.Parse(engineInfo[1]));          
               
                allEngines.Add(newEng);
            }


            string cars;

            while ((cars=Console.ReadLine())!="Show special")
            {
                var carsInfo = cars.Split(' ');

                string Make=carsInfo[0];
                string Model=carsInfo[1];
                int year = int.Parse(carsInfo[2]);
                double fuelQuantity = double.Parse(carsInfo[3]);
                double fuelConsumption = double.Parse(carsInfo[4]);
                int engineIndex = int.Parse(carsInfo[5]);
                int tiresIndex = int.Parse(carsInfo[6]);                

                Car currCar = new Car(Make,Model,year,fuelQuantity,fuelConsumption,allEngines[engineIndex]
                    ,allTires[tiresIndex]);
               allCars.Add(currCar);
            }

            List<Car> specialCar = allCars.Where(x=>x.Year >= 2017).
                Where(x=>x.Engine.HorsePower >330).
                Where(x=>x.Tiers.Sum(x=>x.Pressure) >=9 && x.Tiers.Sum(x=>x.Pressure) <= 10).ToList();

            foreach (var car in specialCar)
            {
                car.Drive(20);

                Console.WriteLine($"Make: {car.Make}");
                Console.WriteLine($"Model: {car.Model}");
                Console.WriteLine($"Year: {car.Year}");
                Console.WriteLine($"HorsePowers: {car.Engine.HorsePower}");
                Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");
            }
        }
           
    }
}
