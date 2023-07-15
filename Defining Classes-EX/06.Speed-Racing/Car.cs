using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Car
    {
        private string model;
        private double fuelAmout;
        private double fuelConsumpionPerKilometer;
        private double travelDistance;        
      
        public string Model { get { return model; } set { model = value; } }

        public double FuelAmount { get { return fuelAmout; } set {fuelAmout=value; } }

        public double FuelConsumptionPerKilometer { get { return fuelConsumpionPerKilometer; }
            set { fuelConsumpionPerKilometer = value; } }

        public double TravelDistance { get { return travelDistance; } set { travelDistance = value; } }

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer
            )
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            this.TravelDistance = 0;
        }
        public  void Drive(double travelDistance)
        {
            //double travelDistance = 0;
            
            if (this.FuelAmount- ((this.FuelConsumptionPerKilometer * travelDistance))>0)
            {
                this.FuelAmount -= (this.FuelConsumptionPerKilometer * travelDistance);
                this.TravelDistance += travelDistance;
            }
            else
            {
                Console.WriteLine($"Insufficient fuel for the drive");
            }
            
           
        }

        public override string ToString()
        {
            return $"{Model} {FuelAmount:F2} {TravelDistance}";
        }
    }



}
