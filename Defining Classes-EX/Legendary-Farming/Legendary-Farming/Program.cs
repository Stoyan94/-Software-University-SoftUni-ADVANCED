namespace Legendary_Farming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> junks = new Dictionary<string, int>();
            Dictionary<string ,int> rareItems= new Dictionary<string, int>()
            {
                ["shards"] = 0,
                ["motes"] = 0,
                ["fragments"] = 0,
            };

            bool isItemCreated = false;

            while (true)
            {
                string[] inputFragments = Console.ReadLine()!.Split();

                for (int i = 0; i < inputFragments.Length; i+=2)
                {
                    int quantity = int.Parse(inputFragments[i]);
                    string item = inputFragments[i+1].ToLower();

                    ChekItemsToAdd(quantity,item,junks,rareItems);

                    if (rareItems.Any(x => x.Value >= 250))
                    {
                        Dictionary<string, string> rareItemsCreated = new Dictionary<string, string>()
                        {
                            ["shards"] = "Shadowmourne",
                            ["fragments"] = "Valanyr",
                            ["motes"] = "Dragonwrath ",
                        };
                        string createdItem = rareItems.FirstOrDefault(x => x.Value >= 250).Key;
                        rareItems[createdItem] -= 250;

                        PrintObtainedItem(rareItemsCreated, createdItem);

                        isItemCreated = true;
                        break;
                    }
                }

                if (isItemCreated)
                {
                    break;
                }
            }

            foreach (var item in rareItems)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach(var item in junks)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }

        public static void PrintObtainedItem(Dictionary<string, string> rareItemsCreated, string createdItem)
        {
            foreach (var item in rareItemsCreated)
            {
                if (item.Key==createdItem)
                {
                    Console.WriteLine($"{item.Value} obtained!");
                }
            }
        }

        public static void ChekItemsToAdd(int quantity, string item, Dictionary<string, int> junks, Dictionary<string, int> rareItems)
        {
            if (rareItems.ContainsKey(item))
            {
                rareItems[item] += quantity;
            }
            else if (!junks.ContainsKey(item)) 
            {
                junks.Add(item, quantity);
            }
            else
            {
                junks[item] += quantity;
            }
        }
    }
}