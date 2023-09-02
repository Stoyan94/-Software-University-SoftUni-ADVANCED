using System;

namespace VendingSystem
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //Initialize the repository (VendingMachine)
            VendingMachine vendingMachine = new VendingMachine(6);

            //Initialize entity (Drink)
            Drink tea = new Drink("Tea", 1.5m, 300);
            Drink coffee = new Drink("Coffee", 2.0m, 120);
            Drink hotChocolate = new Drink("Hot Chocolate", 2.5m, 200);
            Drink latte = new Drink("Latte", 3.5m, 220);
            Drink cappuccino = new Drink("Cappuccino", 2.8m, 180);
            Drink mocha = new Drink("Mocha", 2.1m, 150);
            Drink herbalTea = new Drink("Herbal Tea", 1.75m, 300);

            //Get Count
            Console.WriteLine(vendingMachine.GetCount);
            //0

            //Add Drinks
            vendingMachine.AddDrink(tea);
            vendingMachine.AddDrink(coffee);
            vendingMachine.AddDrink(hotChocolate);
            vendingMachine.AddDrink(latte);
            vendingMachine.AddDrink(cappuccino);
            vendingMachine.AddDrink(mocha);

            //Try to add drinks when the capacity is full
            vendingMachine.AddDrink(herbalTea);

            //Get Count
            Console.WriteLine(vendingMachine.GetCount);
            //6

            //Remove Drink
            Console.WriteLine(vendingMachine.RemoveDrink("Herbal Tea"));
            Console.WriteLine(vendingMachine.RemoveDrink("Tea"));

            //Get Longest Drink
            Console.WriteLine(vendingMachine.GetLongest());
            
            Console.WriteLine();
            //Get Cheapest Drink
            Console.WriteLine(vendingMachine.GetCheapest());
           

            //Buy a specific Drink
            Console.WriteLine(vendingMachine.BuyDrink("Cappuccino"));
          

            //Drinks Report
            Console.WriteLine(vendingMachine.Report());
        

        }
    }
}
