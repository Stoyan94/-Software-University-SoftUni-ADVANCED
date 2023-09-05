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
            if (this.Count == this.data.Length)
            {
                Resize();
            }
            this.data[this.Count] = num;
            this.Count++;
        }
        
        public int RemoveAt(int index)
        {
            this.ValidateIndex(index);

            var result = this.data[index];

            for (int i = index + 1; i < this.Count; i++)
            {
                this.data[i - 1] = this.data[i];
            }
            this.Count--;

            return result;
        }

        public bool Contains(int element)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.data[i] == element)
                {
                    return true;
                }
            }
            return false;
        }

        public void Swap(int firstInedx, int seckondIndex)
        {
            ValidateIndex(firstInedx);
            ValidateIndex(seckondIndex);

            var firstValue = this.data[firstInedx];
            this.data[firstInedx] = this.data[seckondIndex];
            this.data[seckondIndex] = firstValue;
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
            this.data = newData;
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
