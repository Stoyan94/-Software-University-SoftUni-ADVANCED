using System;
using System.Linq;
using System.Collections.Generic;

namespace _10.Party_Reservation_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(' ').ToList();

            string action = Console.ReadLine();

            Dictionary<string,Predicate<string>> allFilters = 
                new Dictionary<string,Predicate<string>>();

            while (action != "Print")
            {
                string[] items = action.Split(";");

                string method = items[0];
                string operation = items[1];
                string value = items[2];


                if (method =="Add filter")
                {
                    allFilters.Add(operation + value,GetPredicate(operation,value));
                }
                else
                {
                    allFilters.Remove(operation + value);
                }

                action = Console.ReadLine();
            }

            foreach (var filter in allFilters)
            {
                names.RemoveAll(filter.Value);
            }

            Console.Write(String.Join(" ",names));
        }

        private static Predicate<string> GetPredicate(string operation, string value)
        {
            if (operation == "Starts with")
            {
                return x => x.StartsWith(value);
            }
            else if (operation == "Ends with")
            {
                return x => x.EndsWith(value);
            }
            else if (operation=="Contains")
            {
                return x => x.Contains(value);
            }

            

            int valueAsInt = int.Parse(value);

            return x => x.Length == valueAsInt;
        }
    }
}
