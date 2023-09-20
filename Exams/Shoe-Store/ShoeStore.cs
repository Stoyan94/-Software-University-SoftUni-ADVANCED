using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoeStore
{
    public class ShoeStore
    {
        private List<Shoe> shoes;
        public ShoeStore(string name, int storageCapacity)
        {
            Name = name;
            StorageCapacity = storageCapacity;
            this.shoes = new List<Shoe>();
        }

        public string Name { get; set; }

        public int StorageCapacity { get; set; }

        IReadOnlyCollection<Shoe> Shoes => shoes;

        public int Cont => Shoes.Count();

        public string AddShoe(Shoe shoe)
        {
            if (Shoes.Count == StorageCapacity)
            {
                return "No more space in the storage room.";
            }
            else
            {
                this.shoes.Add(shoe);
                return $"Successfully added {shoe.Type} {shoe.Material} pair of shoes to the store.";
            }
        }

        public List<Shoe> GetShoesByType(string shoeType)
            =>this.shoes.FindAll(s => s.Type.ToLower() == shoeType.ToLower());        

        public int RemoveShoes(string material)=> Shoes.Where(x=>x.Material == material).Count();

        public Shoe GetShoeBySize(double size) => Shoes.FirstOrDefault(s => s.Size == size);

        public string StockList(int size, string type)
        {           
            List<Shoe> shoes = this.shoes.FindAll(s=>s.Size == size && s.Type == type);

            StringBuilder output = new StringBuilder();

            if (shoes is null)
            {
                output.Append("No matches found!");
                return output.ToString();
            }

            output.AppendLine($"Stock list for size {size} - {type} shoes:");

            foreach (var shoe in shoes)
            {
                if (shoe.Size == size && shoe.Type.ToLower() == type.ToLower())
                {
                    output.AppendLine(shoe.ToString());
                }
            }         

            return output.ToString();
        }
    }

    
}
