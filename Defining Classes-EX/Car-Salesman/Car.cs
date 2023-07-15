using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Salesman
{
//    •	Model: a string property.
//•	Engine: a property holding the engine object.
//•	Weight: an int property, it is optional.
//•	Color: a string property, it is optional.

    public class Car
    {
        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public int? Weight { get; set; }

        public string Color { get; set; }
    }
}
