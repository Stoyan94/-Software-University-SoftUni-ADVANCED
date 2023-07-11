using System;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //one ctro
            Animal animal = new Animal("Hippo",true);

            //ctron in ctro
            Animal ctro2 = new Animal("Hippo", "Female", "hippo", true);

            Console.WriteLine($"I am after constructor");

           

            Console.WriteLine(ctro2.Name);
            Console.WriteLine(ctro2.Species);
            Console.WriteLine(ctro2.Gender);
            Console.WriteLine(ctro2.IsHungry);
        }
    }
}
