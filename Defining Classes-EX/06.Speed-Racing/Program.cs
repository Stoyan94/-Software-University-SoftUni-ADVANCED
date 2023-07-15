using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {

           List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string carModel = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelComsumpion = double.Parse(input[2]);

                Car car = new Car(carModel,fuelAmount,fuelComsumpion);
                
                
                cars.Add(car);
            }

            string carDrive;

            while ((carDrive=Console.ReadLine())!="End")
            {               

                string carModel = carDrive.Split().Skip(1).First();
                int travelDistance= int.Parse(carDrive.Split().Last());

                Car currCar = cars.FirstOrDefault(x=>x.Model ==carModel);
                currCar.Drive(travelDistance);
                
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
