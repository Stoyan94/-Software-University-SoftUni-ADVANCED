using System;
using System.Linq;

namespace _03.Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] text = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

            Func<string, bool> isStartWithCapital = w => char.IsUpper(w[0]);
            
            text= text.Where(isStartWithCapital).ToArray();

            Action<string[]> textPrint = x => 
            Console.WriteLine((string.Join(Environment.NewLine, x)));

            textPrint(text);        

            
        }
    }
}
