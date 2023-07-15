using System;
using System.Linq;
using System.Collections.Generic;

namespace _07.Raw_Data
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numCars= int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
          

            for (int i = 0; i < numCars; i++)
            {
                //"{model} {engineSpeed} {enginePower} {cargoWeight} {cargoType} {tire1Pressure} " +
                // "{tire1Age} {tire2Pressure} {tire2Age} {tire3Pressure} {tire3Age} {tire4Pressure} {tire4Age}"

                string [] input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                int engineSpeed= int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);

                Engien engine = new Engien(engineSpeed, enginePower);

                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];

                Cargo cargo = new Cargo(cargoWeight, cargoType);

                Tire[] tires = new Tire[4];
                int currIndex = 0;

                for (int j = 5; j <= 12; j += 2)
                {
                    
                    double tirePresure = double.Parse(input[5]);                 
                    int tireAge = int.Parse(input[6]);

                    Tire currTire  = new Tire(tireAge,tirePresure);
                    tires[currIndex++] = currTire;
                }
                Car car = new Car(model,engine,cargo,tires);

                cars.Add(car);
            }

            string checkCar= Console.ReadLine();

            List<Car> checkList = new List<Car>();

            if (checkCar=="fragile")
            {
                checkList = cars.Where(x => x.Cargo.Type == "fragile" &&
                 x.Tiers.Any(p => p.Pressure < 1)).ToList();
            }
            else if (checkCar == "flammable")
            {
                checkList =cars.Where(x=>x.Cargo.Type == "flammable" &&
                x.Engien.Power>250).ToList();
            }

            foreach (var car in checkList)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}
