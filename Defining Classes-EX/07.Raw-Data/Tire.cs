using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Raw_Data
{//•	Tires: a collection of exactly 4 tires.Each tire should have two properties: age and pressure.
    public class Tire
    {
        public Tire(int age, double pressure)
        {
            Age = age;
            Pressure = pressure;
        }

        public int Age { get; set; }

        public double Pressure { get; set; }
    }
}
