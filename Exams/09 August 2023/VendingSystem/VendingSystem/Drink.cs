using System;
using System.Collections.Generic;
using System.Text;

namespace VendingSystem
{
    public class Drink
    {
        public Drink(string name, decimal price, int volume)
        {
            this.Name = name;
            this.Price = price;
            this.Volume = volume;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Volume { get; set; }
        public override string ToString()=> $"Name: {Name}, Price: ${Price}, Volume: {Volume} ml";
        
    }
}
