using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.ListyIterator
{
     class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
                .Split()
                .Skip(1)
                .ToList();

            ListyIterator<string> listyIterator = new ListyIterator<string>(elements);

            string command;

            try
            {
                while ((command = Console.ReadLine()) != "END")
                {
                    if (command == "HasNext")
                    {
                        Console.WriteLine(listyIterator.HasNext());
                    }
                    else if (command == "Move")
                    {
                        Console.WriteLine(listyIterator.Move());
                    }
                    else if (command == "Print")
                    {
                        listyIterator.Print();
                    }
                    else if (command=="PrintAll")
                    {
                        foreach (var item in listyIterator)
                        {
                            Console.Write($"{item} ");
                        }
                        Console.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
          
        }
    }
}
