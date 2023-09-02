using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingSystem
{
    public class VendingMachine
    {
        public VendingMachine(int buttonCapacity)
        {
            this.ButtonCapacity = buttonCapacity;
            Drinks = new List<Drink>();
        }

        public int ButtonCapacity { get; set; }
        public List<Drink> Drinks { get; set; }

        public int GetCount() => Drinks.Count();

        public void AddDrink(Drink drink)
        {
            if(ButtonCapacity > Drinks.Count)
            {           
                this.Drinks.Add(drink);
            }
        }

        public bool RemoveDrink(string removeName)=>this.Drinks
            .Remove(this.Drinks.First(x=>x.Name ==removeName));
       

        public Drink GetLongest() => Drinks.OrderByDescending(x=>x.Volume).First();
    
        


    }
}
