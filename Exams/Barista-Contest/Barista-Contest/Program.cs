using System;
using System.Collections.Generic;
using System.Linq;

Dictionary<string, int> tableDrinks = new Dictionary<string, int>()
{
    ["Cortado"] = 50,
    ["Espresso"] = 75,
    ["Capuccino"] = 100,
    ["Americano"] = 150,
    ["Latte"] = 200,
};

Dictionary<string, int> createdCofee = new Dictionary<string, int>();


Queue<int> coffeInput = new Queue<int>(Console.ReadLine().Split(",").Select(int.Parse));

Stack<int> milkInput = new Stack<int>(Console.ReadLine().Split(",").Select(int.Parse));


while (coffeInput.Any() && milkInput.Any())
{
    int result = coffeInput.Peek() + milkInput.Peek();

    if (tableDrinks.ContainsValue(result))
    {
        string nameCoffe = tableDrinks.First(x => x.Value == result).Key;   
        
        if (!createdCofee.ContainsKey(nameCoffe))
        {
            createdCofee.Add(nameCoffe, 0);
        }
        createdCofee[nameCoffe] += 1;
        coffeInput.Dequeue();
        milkInput.Pop();
    }
    else
    {
        coffeInput.Dequeue();
        milkInput.Push(milkInput.Pop()-5);
    }
}


if (coffeInput.Any() || milkInput.Any())
{
    Console.WriteLine("Nina needs to exercise more! She didn't use all the coffee and milk!");

    string isCofeeLeft = coffeInput.Count() > 0
        ? string.Join(", ", coffeInput) : "none";

    Console.WriteLine($"Coffee left: {isCofeeLeft}");

    string isMilkLeft = milkInput.Count() > 0
        ? string.Join(", ", milkInput) : "none";
    Console.WriteLine($"Milk left: {isMilkLeft}");
}
else
{
    Console.WriteLine("Nina is going to win! She used all the coffee and milk!");
    Console.WriteLine("Coffee left: none");
    Console.WriteLine("Milk left: none");
}

foreach (var drink in createdCofee.OrderBy(x => x.Value).ThenByDescending(x => x.Key))
{
    Console.WriteLine($"{drink.Key}: {drink.Value}");
}

