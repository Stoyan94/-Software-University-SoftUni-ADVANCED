using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        public Family()
        {
            Femaly = new List<Person>();
        }
        public List<Person> Femaly { get; set; }

        public void AddMemer(Person person)
        {
            Femaly.Add(person);
        }

        public List<Person> GetOldestMember()
        {
            List<Person> person = Femaly.FindAll(p => p.Age>=30).OrderBy(n=>n.Name).ToList();           

            return person;
        }
    }
}
