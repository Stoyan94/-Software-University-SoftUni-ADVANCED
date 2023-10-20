   

 Stack<int> STACK = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

 Queue<int> QUEUE = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

 Dictionary<string, int> table = new Dictionary<string, int>()
 {
     [""] = 0,
     [""] = 0,
     [""] = 0,
     [""] = 0,
     [""] = 0,
 };

 SortedDictionary<string, int> typeAreaRenovation = new SortedDictionary<string, int>();                


 while (STACK.Any() && QUEUE.Any())
 {                
     int result = STACK.Peek() + QUEUE.Peek();

     if (table.ContainsValue(result))
     {
         string nameArea = table.FirstOrDefault(x => x.Value == result).Key;

         if (!typeAreaRenovation.ContainsKey(nameArea))
         {
             typeAreaRenovation[nameArea] = 0;
         }
         typeAreaRenovation[nameArea] += 1;

         STACK.Pop();
         QUEUE.Dequeue();
     }
     else
     {
         STACK.Pop();
         QUEUE.Dequeue();

     }
 }

 string isWihteTilesUsed = STACK.Count() > 0
     ? string.Join(", ", STACK) : "none";

 string isGteyTilesUsed = QUEUE.Count() > 0
     ? string.Join(", ", QUEUE) : "none";

 Console.WriteLine($"White tiles left: {isWihteTilesUsed}");
 Console.WriteLine($"Grey tiles left: {isGteyTilesUsed}");

 foreach (var item in typeAreaRenovation.OrderByDescending(v => v.Value))
 {
     Console.WriteLine($"{item.Key}: {item.Value}");
 }

