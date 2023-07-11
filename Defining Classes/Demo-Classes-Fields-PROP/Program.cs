using System;

namespace Demo_Classes_Fields_PROP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Gogi";
            person.LastName = "Gogov";

            Console.WriteLine($"{person.FullName}");
            return;

            Car car = new Car();
            car.Mileage = 5;
            Console.WriteLine($"Mileage: {car.Mileage}");  
            
            car.Mileage = -5;
            Console.WriteLine($"Mileage: {car.Mileage}");    
            
            car.Mileage += 15;
            Console.WriteLine($"Mileage: {car.Mileage}");
        }
    }
}
