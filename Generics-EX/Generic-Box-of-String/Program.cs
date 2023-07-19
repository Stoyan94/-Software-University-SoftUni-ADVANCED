using System;
using System.Linq;

namespace Generic_Box_of_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Box<string> box = new Box<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                box.Items.Add(input);
            }

            string wordToCompare = Console.ReadLine();
            
            int value = box.CountGreater(wordToCompare);

            Console.WriteLine(value);
        }
    }
}
