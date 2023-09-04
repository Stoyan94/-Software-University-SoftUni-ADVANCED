namespace CustomDataStructure
{
    public class Program
    {
        static void Main(string[] args)
        {           
            var csList = new CustomList();

            csList.Add(10);
            csList.Add(20);
            csList.Add(30);

            var cout = csList.Count;

            Console.WriteLine(cout);

            csList[0] = 100;
            var number = csList[1];
            Console.WriteLine(number);
            Console.WriteLine(csList[2]);

            csList.Clear();

            Console.WriteLine(csList.Count);
        }
    }
}