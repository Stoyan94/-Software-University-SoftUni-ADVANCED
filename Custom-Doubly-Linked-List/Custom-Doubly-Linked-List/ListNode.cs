
namespace Custom_Doubly_Linked_List
{
    public class ListNode
    {
        public ListNode(int value) 
        {
            this.Value = value;
        }
        public int Value { get; set; }

        public ListNode NextNode { get; set; }

        public ListNode PrevionsNode { get; set; }

        public override string ToString() //only for debug
        {
            return this.Value.ToString();
        }

    }
}
