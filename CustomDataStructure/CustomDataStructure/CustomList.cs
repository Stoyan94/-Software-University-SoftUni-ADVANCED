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
            if (this.Count == capacity)
            {
                Resize();
            }
            this.data[this.Count] = num;
            this.Count++;
        }
        
        public bool this[string text]
        {
            get
            {
                return text == "stoqn";
            }
        }
        public int this[int index]
        {
            get
            {
               this.ValidateIndex(index);

                return this.data[index];
            }
            set
            {
                this.ValidateIndex(index);

                this.data[index] = value;
            }
        }

        public void Clear()
        {
            this.Count = 0;
            this.data = new int[capacity];
        }

        private void Resize()
        {
            var newCapacity = this.data.Length * 2;
            
            var newData = new int[newCapacity];

            for (int i = 0; i < this.data.Length; i++)
            {
                newData[i] = this.data[i];
            }
        }

        private void ValidateIndex(int index)
        {
            if (index >= 0 || index < this.Count)
            {
                return;
            }
            var message = this.Count == 0
                ? "The list is empty"
                : $"The list has {this.Count-1} elements and it is zero-based.";
                        
                throw new Exception($"Index out of range. {message}");
            
        }
    }
}
