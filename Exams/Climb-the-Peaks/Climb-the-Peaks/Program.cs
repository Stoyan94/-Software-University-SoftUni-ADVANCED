using System;
using System.Collections.Generic;
using System.Linq;

List<string> conquerPeaks = new List<string>();

Stack<int> foodPortions = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse)); 

Queue<int> stamina = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse));

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
    int energy = foodPortions.Pop() + stamina.Dequeue();   
    

    foreach (var peak in tableDif)
    {
        int result = 0;

        if (peak.Value - energy >= 0)
        {
            result = peak.Value - energy;
            tableDif[peak.Key] = result;
        }
        else
        {
            tableDif[peak.Key] = 0;
        }

        if (tableDif[peak.Key] == 0) 
        {
            conquerPeaks.Add(peak.Key);
            tableDif.Remove(peak.Key);
        }

        break;
    }  
}

Console.WriteLine(string.Join("\n",conquerPeaks));


 


