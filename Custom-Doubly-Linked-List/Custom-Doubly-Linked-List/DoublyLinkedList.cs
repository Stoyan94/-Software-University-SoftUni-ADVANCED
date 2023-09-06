
namespace Custom_Doubly_Linked_List
{
    public class DoublyLinkedList
    {
        private ListNode head;
        private ListNode tail;
        public int Cont { get; private set; }

        public void AddFirst(int element)
        {
            if (this.Cont == 0)
            {
                this.head = this.tail= new ListNode(element);                
            }
            else
            {
                ListNode newHead = new ListNode(element);
                ListNode oldHead = this.head;

                this.head = newHead;
                oldHead.PrevionsNode = newHead;
                newHead.NextNode = oldHead;
            }
            this.Cont++;
        }

        public void AddLast(int element)
        {
            if (this.Cont == 0)
            {
                this.head = this.tail = new ListNode(element);
            }
            else
            {
                ListNode newTail = new ListNode(element);
                ListNode oldHTail = this.tail;

                this.tail = newTail;
                oldHTail.NextNode = newTail;
                newTail.PrevionsNode = oldHTail;
            }
            this.Cont++;
        }
    }
}
