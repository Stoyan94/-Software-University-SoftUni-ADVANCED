using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoeStore
{
    public class ShoeStore
    {
        public ShoeStore(string name, int storageCapacity)
        {
            Name = name;
            StorageCapacity = storageCapacity;
            Shoes = new List<Shoe>();
        }

        public string Name { get; set; }

        public int StorageCapacity { get; set; }

        public List<Shoe> Shoes { get; set; }

        public int Cont => Shoes.Count();

        public string AddShoe(Shoe shoe)
        {
            if (Shoes.Count < StorageCapacity)
            {
                Shoes.Add(shoe);
                return $"Successfully added {shoe.Type} {shoe.Material} pair of shoes to the store.";
            }
            else
            {
                return "No more space in the storage room.";
            }
        }

        public List<Shoe> GetShoesByType(string shoeType)
        {
            List<Shoe> shoe = Shoes.FindAll(s => s.Type.ToLower() == shoeType);


            return shoe;
        }

        public int RemoveShoes(string material)=> Shoes.Where(x=>x.Material == material).Count();
        }
    }
}
