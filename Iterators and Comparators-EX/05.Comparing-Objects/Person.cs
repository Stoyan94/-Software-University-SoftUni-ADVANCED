using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Comparing_Objects
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age, string town)
        {
            Name = name;
            Age = age;
            Town = town;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Town { get; set; }

        public int CompareTo(Person other)
        {
            int names = this.Name.CompareTo(other.Name);
            if (names != 0)
            {
                return names;
            }

            int age = this.Age.CompareTo(other.Age);

            if (age != 0)
            {
                return age;
            }

            int towns = this.Town.CompareTo(other.Town);

            if (towns !=0)
            {
                return towns;
            }

            return 0;
        }
    }
}
