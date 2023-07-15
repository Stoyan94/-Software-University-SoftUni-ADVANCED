using System;
using System.Linq;
using System.Collections.Generic;

namespace Car_Salesman
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();           

            int numEngines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numEngines; i++)
            {     

                string[] enginesInput = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);

                string engineModel = enginesInput[0];
                int enginePower = int.Parse(enginesInput[1]);

                Engine engine = new Engine(engineModel,enginePower);

                if (enginesInput.Length ==4)
                {
                    int engDisplacement = int.Parse(enginesInput[2]);
                    string efficiency  = enginesInput[3];

                    engine.Displacement = engDisplacement;
                    engine.Efficiency = efficiency;
                }

                if (enginesInput.Length==3)
                {
                    bool isDisplacement = int.TryParse(enginesInput[2], out var disp);

                    if (isDisplacement)
                    {
                        engine.Displacement = disp;

                    }
                    else
                    {
                        engine.Efficiency = enginesInput[2];
                    }
                }

                engines.Add(engine);
            }

            int numCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numCars; i++)
            {
       
        
                string [] inputCar = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string carModel = inputCar[0];
                string carEngine = inputCar[1];

                Engine currEngine = engines.FirstOrDefault(x=>x.Model == carEngine);

                Car car = new Car(carModel, currEngine);

                if (inputCar.Length==4)
                {
                    int carWeight = int.Parse(inputCar[2]);
                    string carColor = inputCar[3];

                    car.Weight = carWeight;
                    car.Color = carColor;
                }

                if (inputCar.Length==3)
                {
                    bool isWeight = int.TryParse(inputCar[2], out var weight);

                    if (isWeight)
                    {
                        car.Weight = weight;
                    }
                    else
                    {
                        car.Color= inputCar[2];
                    }
                }
                cars.Add(car);
            }


            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");

                string dispoInfo = car.Engine.Displacement.HasValue ?
                    $"    Displacement: {car.Engine.Displacement}" :
                    $"    Displacement: n/a";
                Console.WriteLine(dispoInfo);

                string efficiencyInfo = car.Engine.Efficiency !=null ?
                    $"    Efficiency: {car.Engine.Efficiency}" :
                    $"    Efficiency: n/a";
                Console.WriteLine(efficiencyInfo);

                string weightInfo = car.Weight.HasValue ?
                   $"  Weight: {car.Weight}" :
                   $"  Weight: n/a";
                Console.WriteLine(weightInfo); 
                
                string colorInfo = car.Color!=null ?
                   $"  Color: {car.Color}" :
                   $"  Color: n/a";
                Console.WriteLine(colorInfo);
            }

            //              "{CarModel}:
            //                {EngineModel}:
            //                 Power: {EnginePower}
            //                 Displacement: { EngineDisplacement}
            //                 Efficiency: { EngineEfficiency}
            //                Weight: { CarWeight}
            //                Color: { CarColor}
        }
    }
}
