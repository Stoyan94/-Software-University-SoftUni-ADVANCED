namespace Custom_Doubly_Linked_List
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            DoublyLinkedList doublyLinkedList = new DoublyLinkedList();

            for (int i = 0; i < 3; i++)
            {
                doublyLinkedList.AddFirst(i);
            }
        }
    }
}