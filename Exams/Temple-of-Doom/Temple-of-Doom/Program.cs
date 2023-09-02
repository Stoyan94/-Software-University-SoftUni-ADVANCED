namespace Temple_of_Doom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> tools = new Queue<int>(Console.ReadLine()!.Split().Select(int.Parse));
            Stack<int> subtances = new Stack<int>(Console.ReadLine()!.Split().Select(int.Parse));

            List<int> challenges = Console.ReadLine()!.Split().Select(int.Parse).ToList();

            int getMax = Math.Max(tools.Count, subtances.Count);
           
            while (tools.Count> 0 && subtances.Count> 0)           
            {
                bool isItemFound = false;
                int craftResult = tools.Peek() * subtances.Peek();
               
                for (int i = 0; i < challenges.Count; i++)
                {
                    if (craftResult == challenges[i])
                    {
                        tools.Dequeue();
                        subtances.Pop();
                        challenges.RemoveAt(i);
                        isItemFound = true;
                        break;
                    }
                }

                if (!isItemFound)
                {
                    int toolAdd = tools.Dequeue() + 1;
                    tools.Enqueue(toolAdd);

                    if (subtances.Peek() -1 > 0)
                    {
                        int subtanceRemove = subtances.Pop() - 1;
                        subtances.Push(subtanceRemove);
                    }
                    else
                    {
                        subtances.Pop();
                    }
                }
            }

            if (challenges.Count > 0)
            {
                Console.WriteLine("Harry is lost in the temple. Oblivion awaits him.");

                if (tools.Count > 0)
                {
                    Console.Write("Tools: ");
                    Console.WriteLine(string.Join(", ", tools));
                }
                if (subtances.Count > 0)
                {
                    Console.Write($"Substances: ");
                    Console.WriteLine(string.Join(", ", subtances));
                }
                Console.Write($"Challenges: ");
                Console.WriteLine(string.Join(", ", challenges));
            }
            else
            {
                Console.WriteLine("Harry found an ostracon, which is dated to the 6th century BCE.");
                if (tools.Count > 0)
                {
                    Console.Write("Tools: ");
                    Console.WriteLine(string.Join(", ", tools));
                }
                if (subtances.Count > 0)
                {
                    Console.Write($"Substances: ");
                    Console.WriteLine(string.Join(", ", subtances));
                }
              
            }
        }
    }
}