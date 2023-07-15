using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Raw_Data
{
//    •	Model: a string property
//•	Engine: a class with two properties – speed and power,
//•	Cargo: a class with two properties – type and weight 
//•	Tires: a collection of exactly 4 tires.Each tire should have two properties: age and pressure.

    public class Car
    {
        public Car(string model, Engien engien, Cargo cargo, Tire[] tiers)
        {
            Model = model;
            Engien = engien;
            Cargo = cargo;
            Tiers = tiers;
        }

        public string Model { get; set; }

        public Engien Engien { get; set; }

        public Cargo Cargo { get; set; }

        public Tire[] Tiers { get; set; }
    }
}
