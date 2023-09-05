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

            for (int i = 0; i < 10; i++)
            {
                csList.Add(i);
            }
            Console.WriteLine();

            var newList = new CustomList();

            newList.Add(10);
            newList.Add(20);
            newList.Add(30);

            var removed = newList.RemoveAt(2);          
            
            for (int i = 0;i < newList.Count; i++)
            {
                Console.WriteLine(newList[i]);
            }

            Console.WriteLine(newList.Count);
            Console.WriteLine(newList.Contains(10));

            newList.Swap(0, 1);

            for (int i = 0; i < newList.Count; i++)
            {
                Console.WriteLine(newList[i]);
            }

            newList.Insert(1, 10);
            Console.WriteLine();

        }
    }
}