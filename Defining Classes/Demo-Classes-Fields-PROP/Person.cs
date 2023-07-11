using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Classes_Fields_PROP
{
    internal class Person
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        // можем и да групираме полета в дадено prop. да използва нашите вътрешнни данни        
        public string FullName
        {
            get 
            { 
                return $"{firstName} { lastName}";
            }

        }
    }
}
