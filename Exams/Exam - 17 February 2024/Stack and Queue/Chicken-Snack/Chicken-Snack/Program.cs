using System;
using System.Collections.Generic;
using System.Linq;

Stack<int> money = new(Console.ReadLine().Split(" ").Select(int.Parse));

Queue<int> prices = new(Console.ReadLine().Split(" ").Select(int.Parse));

int eatFood = 0;

while (money.Any() && prices.Any())
{
    int currentMoney = money.Peek();
    int currentPrice = prices.Peek();

    if (currentMoney == currentPrice)
    {
        money.Pop();
        prices.Dequeue();
        eatFood++;
    }
    else if (currentMoney > currentPrice)
    {
        int calculateChange = currentMoney - prices.Dequeue();

        money.Push(money.Pop() + calculateChange);
        eatFood++;
    }
    else if (currentMoney < currentPrice)
    {
        money.Pop();
        prices.Dequeue();
    }
}

if (eatFood >= 4)
{
    Console.WriteLine($"Gluttony of the day! Henry ate {eatFood} foods.");
}
else
{
    if (eatFood == 0)
    {
        Console.WriteLine("Henry remained hungry. He will try next weekend again.");
    }
    else if (eatFood == 1)
    {
        Console.WriteLine($"Henry ate: {eatFood} food.");
    }
    else
    {
        Console.WriteLine($"Henry ate: {eatFood} foods.");
    }
}
