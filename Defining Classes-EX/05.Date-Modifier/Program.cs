using System;

namespace _05.Date_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string startDate = Console.ReadLine();
            string endDate = Console.ReadLine();

            int result =  DateModifier.CalculateDate(startDate, endDate);

            Console.WriteLine(result);
        }
    }
}
