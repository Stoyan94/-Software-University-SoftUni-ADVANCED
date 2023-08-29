namespace Monster_Extermination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputMonster = Console.ReadLine()!.Split(",").Select(int.Parse).ToArray();
            int[] inputSoldier = Console.ReadLine()!.Split(",").Select(int.Parse).ToArray();

            Stack<int> soldierStrike =  new Stack<int>(inputSoldier);
            Queue<int> armorMonstter = new Queue<int>(inputMonster);

            int monsterKilled = 0;
          

            while (armorMonstter.Count>0 && soldierStrike.Count>0)
            {
                int resultFight = 0;               

                if (armorMonstter.Peek()<=soldierStrike.Peek())
                {                  
                    monsterKilled++;

                    resultFight = soldierStrike.Pop() - armorMonstter.Dequeue();


                    if (resultFight > 0)
                    {
                        int addNextStrike = soldierStrike.Pop() + resultFight;
                        soldierStrike.Push(addNextStrike);
                    }
                  
                }
                else
                {
                    resultFight =  armorMonstter.Dequeue() - soldierStrike.Pop();
                   
                    armorMonstter.Enqueue(resultFight);                 

                }               
            }

            if (soldierStrike.Count>0) 
            {
                Console.WriteLine($"All monsters have been killed!");
                Console.WriteLine($"Total monsters killed: {monsterKilled}");
            }
            else
            {
                Console.WriteLine($"The soldier has been defeated.");
                Console.WriteLine($"Total monsters killed: {monsterKilled}");
            }
           
        }

       
    }
}