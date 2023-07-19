using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.Comparing_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string info;

            while ((info = Console.ReadLine())!="END")
            {
                string[] personInfo = info.Split();

                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);
                string town = personInfo[2];

                Person person = new Person(name, age, town);
                people.Add(person); 
            }

            int n = int.Parse(Console.ReadLine());

            Person personToCompare = people[n-1];

            int equals = 0;
            int diff = 0;

            foreach (var person in people)
            {
                if (person.CompareTo(personToCompare)==0)
                {
                    equals++;
                }
                else
                {
                    diff++;
                }
            }

            if (equals==1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
             Console.WriteLine($"{equals} {diff} {people.Count}");
            }
        }
    }
}
