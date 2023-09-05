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
            this.isStackEmpty();

            var result = this.data[this.Count-1];

            this.Count--;

            return result;
        }

        public int Peek()
        {
            this.isStackEmpty();

            return this.data[this.Count - 1];
        }

        public void Clear()
        {
            this.data = new int[this.capacity];
        }

        public void ForEach(Action<int> action)
        {
            for (int i = this.Count - 1; i >=0 ; i--)
            {
                action(this.data[i]);
            }
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

        private void isStackEmpty()
        {
            if (this.Count == 0)
            {
                throw new Exception("Stack is empty.");
            }
        }
    }
}
