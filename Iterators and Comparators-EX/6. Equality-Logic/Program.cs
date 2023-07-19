using System;
using System.Linq;
using System.Collections.Generic;

namespace _6._Equality_Logic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<Person> sortedSet = new SortedSet<Person>();
            HashSet<Person> hashSet = new HashSet<Person>();

            int integerValue = int.Parse(Console.ReadLine());

            for (int i = 0; i < integerValue; i++)
            {
                string[] personInfo = Console.ReadLine().Split();

                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);                

                Person person = new Person(name, age);

                sortedSet.Add(person);
                hashSet.Add(person);
            }

            Console.WriteLine(sortedSet.Count);
            Console.WriteLine(hashSet.Count);

        }
    }
}
