using System.Text;

namespace OffroadChallenge
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Stack<int> fuel = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));

            Queue<int> consmFuel = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));

            Queue<int> altitudes = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));

            int countWins = 0;         

           while (fuel.Any() && consmFuel.Any())
           {
                int result = fuel.Peek() - consmFuel.Peek();
                
                if (result >= altitudes.Peek())
                {
                    fuel.Pop();
                    consmFuel.Dequeue();
                    altitudes.Dequeue();
                    countWins++;

                    Console.WriteLine($"John has reached: Altitude {countWins}");
                }
                else
                {                    
                    int failtAt = countWins + 1;
                    Console.WriteLine($"John did not reach: Altitude {failtAt}");
                    break;
                }
           }

            if (altitudes.Count == 0)
            {
                Console.WriteLine("John has reached all the altitudes and managed to reach the top!");
            }
            else
            {
                if (countWins == 0)
                {
                    Console.WriteLine("John failed to reach the top.");
                    Console.WriteLine("John didn't reach any altitude.");
                }
                else 
                {
                    Console.WriteLine("John failed to reach the top.");

                    StringBuilder sb = new StringBuilder();

                    sb.Append("Reached altitudes: ");

                    if (countWins == 1)
                    {
                        sb.Append($"Altitude {countWins}");
                        Console.WriteLine(sb);
                        return;
                    }

                    for (int i = 1; i <= countWins; i++)
                    {
                        if (i == countWins)
                        {
                            sb.Append($" Altitude {i}");
                            break;
                        }

                        sb.Append($"Altitude {i},");
                    }                   

                    Console.WriteLine(sb);

                }
            }
           
        }
    }
}