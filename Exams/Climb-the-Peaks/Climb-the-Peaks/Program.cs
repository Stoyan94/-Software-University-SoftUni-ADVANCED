using System;
using System.Collections.Generic;
using System.Linq;

Queue<int> foodPortions = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse));

Stack<int> stamina = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse)); 

Dictionary<string,int> tableDif = new Dictionary<string, int>()
{
    ["Vihren"] = 80,
    ["Kutelo"] = 90,
    ["Banski Suhodol"] = 100,
    ["Polezhan"] = 60,
    ["Kamenitza"] = 70,
};

while (foodPortions.Any() || stamina.Any())
{

}


 


