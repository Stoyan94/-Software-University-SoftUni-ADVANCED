using System;
using System.Linq;
using System.Collections.Generic;

namespace DefiningClasses
{
     public class StartUp
    {
        static void Main(string[] args)
        {
            Family family = new Family();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                int age = int.Parse(input[1]);
                Person person = new Person(name,age);
                
                family.AddMemer(person);
            }

            List<Person> oldest = family.GetOldestMember();

            foreach (var people in oldest)
            {
                Console.WriteLine($"{people.Name} - {people.Age}");
            }
        }
    }
}
