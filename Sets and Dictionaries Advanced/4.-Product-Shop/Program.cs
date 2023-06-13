using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,Dictionary<string,double>> shops = new Dictionary<string,Dictionary<string, double>>();

            string inputShop;

            while ((inputShop= Console.ReadLine())!= "Revision")
            {
                string[] currShopInput = inputShop.Split(",", StringSplitOptions.RemoveEmptyEntries);

                var shopName = currShopInput[0];
                var shopProduct = currShopInput[1];
                var shopPrice = double.Parse(currShopInput[2]);

                if (!shops.ContainsKey(shopName))
                {
                    shops.Add(shopName, new Dictionary<string, double>());
                }
                shops[shopName].Add(shopProduct,shopPrice);
            }

            shops = shops.OrderBy(x => x.Key).ToDictionary(x=>x.Key,x=>x.Value);

            foreach (var shopName in shops)
            {
                Console.WriteLine($"{shopName.Key}->");
                foreach (var product in shopName.Value)
                {
                    Console.WriteLine($"Product:{product.Key}, Price: {product.Value}");
                }
            }

        }
    }
}
