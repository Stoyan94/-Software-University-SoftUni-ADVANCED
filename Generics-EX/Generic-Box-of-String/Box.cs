using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Box_of_String
{
    public class Box<T>
        where T : IComparable
    {
        public Box()
        {
            Items = new List<T>();
        }
        public List<T> Items { get; set; }

        public int CountGreater(T itemToCompare)
            => Items.Count(x=>x.CompareTo(itemToCompare)>0);
       
        public override string ToString()
            => string.Join(Environment.NewLine,
                Items.Select(x=>$"{typeof(T)}: {x}"));
        
        public void Swap(int firstIndex,int seckondIndex)
          => (Items[firstIndex], Items[seckondIndex])
           = (Items[seckondIndex], Items[firstIndex]);
       
      
    }   
}
