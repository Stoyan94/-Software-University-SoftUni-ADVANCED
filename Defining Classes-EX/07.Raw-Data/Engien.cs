using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Raw_Data
{//•	Engine: a class with two properties – speed and power,
    public class Engien
    {
        public Engien(int speed, int power)
        {
            Speed = speed;
            Power = power;
        }

        public int Speed { get; set; }

        public int Power { get; set; }
    }
}
