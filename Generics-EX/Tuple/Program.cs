using System;

namespace Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyTuple<string, int> my =
                new MyTuple<string, int>("11", 1);

            Console.WriteLine(my.Item1);
            Console.WriteLine(my.Item2); 
            
            Tuple<string, int> tuple =
                new Tuple<string, int>("11", 1);

            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);
            
        }
    }
}
