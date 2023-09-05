using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{
    public class CustomStack
    {
        private int[] data;

        public CustomStack()
        {
            this.data = new int[4];
        }
        public int Count { get;}
        public void Push()
        {

        }
        public int Pop()
        {
            return 0;
        }

        public int Peek()
        {
            return 0;
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
