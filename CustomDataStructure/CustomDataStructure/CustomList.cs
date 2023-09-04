using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDataStructure
{
    public class CustomList
    {
        private int capacity;
        private int[] data;

        public CustomList()
            : this(4)
        {            
        }

        public CustomList(int capacity)
        {
            this.capacity = capacity;
            this.data = new int[capacity];       
        }
        

        public int Count { get; private set; }
        public void Add(int num)
        {
            this.data[this.Count] = num;
            this.Count++;
        }

        public int this[int index]
        {
            get
            {
                return this.data[index];
            }
            set
            {
                this.data[index] = value;
            }
        }

        public void Clear()
        {
            this.Count = 0;
            this.data = new int[capacity];
        }
    }
}
