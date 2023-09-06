namespace Rubber_Duck_Debuggers
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Queue<int> timeGiven = new Queue<int>(Console.ReadLine()!
                .Split().Select(int.Parse));

            Stack<int> tasks = new Stack<int>(Console.ReadLine()!
                .Split().Select(int.Parse));

            Dictionary<string, int> ducks = new Dictionary<string, int>()
            {
                { "Darth Vader Ducky", 0 },
                { "Thor Ducky", 0 },
                { "Big Blue Rubber Ducky", 0 },
                { "Small Yellow Rubber Ducky", 0 }
            };

           while (timeGiven.Count > 0 && tasks.Count > 0)
           {
                int currTaksFinish = timeGiven.Peek() * tasks.Peek();

                if ((currTaksFinish >= 0) && (currTaksFinish <= 240))
                {                  
                    DucksCreated(currTaksFinish, ducks);

                    timeGiven.Dequeue();
                    tasks.Pop();
                    continue;
                }
                else
                {
                    tasks.Push(tasks.Pop() - 2);
                    timeGiven.Enqueue(timeGiven.Dequeue());
                }
            }

            
        }

        private static void DucksCreated(int calcTime, Dictionary<string, int> ducks)
        {
            if ((calcTime >= 0) && (calcTime <= 60))
            {
                ducks["Darth Vader Ducky"]++;
            }
            else if ((calcTime >= 61) && (calcTime <= 120))
            {
                ducks["Thor Ducky"]++;
            }
            else if ((calcTime >= 121) && (calcTime <= 180))
            {
                ducks["Big Blue Rubber Ducky"]++;
            }
            else if ((calcTime >= 181) && (calcTime <= 240))
            {
                ducks["Small Yellow Rubber Ducky"]++;
            }
        }
    }
}