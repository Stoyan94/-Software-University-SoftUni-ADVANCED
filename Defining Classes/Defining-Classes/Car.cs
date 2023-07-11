using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes
{
    internal class Car
    {
        public string Name { get; set; }

        public string Company { get; set; }

        public string Category { get; set; }

        public decimal Price { get; set; }

        public int Milage { get; set; }
        

        public void Drive(int km)
        {
            Milage += km;
            Console.WriteLine($"Car {Name} {Company} driven for {Milage} km");
        }
    }
}
