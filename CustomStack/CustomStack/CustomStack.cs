using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{
    public class CustomStack
    {
        private int capacity;
        private int[] data;

        public CustomStack()
            :this(4)
        {          
        }

        public CustomStack(int caplacity)
        {
            this.capacity = caplacity;
            this.data = new int[caplacity];
        }
        public int Count { get; private set;}
        public void Push(int num)
        {
            if (this.Count == this.data.Length)
            {
                Resize();
            }
            this.data[this.Count] = num;
            Count++;
        }
        public int Pop()
        {
            return 0;
        }

        public int Peek()
        {
            return 0;
        }

        public void Clear()
        {
            this.data = new int[this.capacity];
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
    }
}
