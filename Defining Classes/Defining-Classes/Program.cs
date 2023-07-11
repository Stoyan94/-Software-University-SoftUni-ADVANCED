using System;

namespace Defining_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car bwm = new Car()
            {
                Name ="3",
                Company = "BWM",
                Category = "Cars",
                Price = 3000
            };
            bwm.Drive(100);
            bwm.Drive(20);

            Car audi = new Car()
            {
                Name = "a3",
                Company = "Audi",
                Category = "Cars",
                Price = 3500
            };
            audi.Drive(150);
            audi.Drive(25);

            Console.WriteLine($"Car: {bwm.Name}, {bwm.Price}, {bwm.Company} - Milage {bwm.Milage}km");

            Console.WriteLine($"Car: {audi.Name}, {audi.Price}, {audi.Company} - Milage {audi.Milage}km");
        }
    }
}
