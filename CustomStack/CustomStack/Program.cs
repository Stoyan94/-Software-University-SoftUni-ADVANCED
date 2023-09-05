namespace CustomStack
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            var myStack = new CustomStack();

            myStack.Push(10);
            myStack.Push(20);

            var result = myStack.Pop();

            Console.WriteLine(result);

            var peekResult = myStack.Peek();

            Console.WriteLine(peekResult);

            Console.WriteLine(myStack.Count);

            myStack.Clear();

            Console.WriteLine(myStack.Count);

            Console.WriteLine();

            for (int i = 1; i < 4; i++)
            {
                myStack.Push(i);
            }

            myStack.Peek();          

            Console.WriteLine();

            myStack.ForEach(x => Console.WriteLine(x * 10));

            myStack.Pop();
            myStack.Pop();
            myStack.Pop();
            myStack.Pop();
            myStack.Pop();
           
        }
    }
}