using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Vehicle_Catalogue_OOP_2._0
{
     class CatalogVehicles
    {
        public CatalogVehicles(string type,string model, string color, int horsePower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
            this.Catalog = new List<CatalogVehicles>();
        }

        public List<CatalogVehicles> Catalog { get; set; }

        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int HorsePower { get; set; }

        public override string ToString()
        {
            return (@$"Type: {this.Type}
Model: {this.Model} 
Color: {this.Color} 
HorsePower: {this.HorsePower}");
        }

    }
}
