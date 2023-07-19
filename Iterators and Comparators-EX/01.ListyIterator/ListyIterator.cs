using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private readonly List<T> elements;
        private int index;
        public ListyIterator(List<T> elements)
        {
            this.elements = elements;
            this.index = 0;
        }

        public bool Move()
        {
            if (index < elements.Count-1)
            {
                index++;
                return true;
            }

            return false;
        }

        public bool HasNext()
           =>index +1 < elements.Count;

        public void Print()
        {
            if (elements.Count == 0)
            {
                throw new Exception("Invalid Operation");
            }

            Console.WriteLine(elements[index]);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in elements)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        =>this.GetEnumerator();
    }
}
