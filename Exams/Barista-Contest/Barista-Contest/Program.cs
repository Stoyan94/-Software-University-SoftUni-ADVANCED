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



