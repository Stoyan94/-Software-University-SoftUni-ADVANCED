using System;
using System.Linq;

namespace _07.Predicate_For_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {        

            int nameLeght = int.Parse(Console.ReadLine());

            string [] names = Console.ReadLine().Split(' ');

            Func<string, int, bool> leghtName = (x, y) => x.Length <= y;            

            string [] resultNames = names.Where(x=>(x.Length <=nameLeght)).ToArray();           
            
            Action<string[]> action = print => Console.WriteLine(string.Join(Environment.NewLine, print));

            action(resultNames);
        }
    }
}
