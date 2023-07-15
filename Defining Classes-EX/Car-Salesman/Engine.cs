using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Salesman
{
//    •	Model: a string property.
//•	Power: an int property.
//•	Displacement: an int property, it is optional.
//•	Efficiency: a string property, it is optional.

    public class Engine
    {
        public Engine(string model, int power)
        {
            Model = model;
            Power = power;
          
        }

        public string Model { get; set; }

        public int Power { get; set; }

        public int? Displacement { get; set; }

        public string Efficiency { get; set; }
    }
}
