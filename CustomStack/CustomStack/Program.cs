namespace CustomStack
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            var myStack = new CustomStack();

            myStack.Push(10);

            var result = myStack.Pop();

            Console.WriteLine(result);

            var peekResult = myStack.Peek();

            Console.WriteLine(peekResult);

            Console.WriteLine(myStack.Count);
        }
    }
}