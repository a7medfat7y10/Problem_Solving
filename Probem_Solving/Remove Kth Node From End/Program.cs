namespace Remove_Kth_Node_From_End
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Remove Kth Node From End");
        }
        public static void RemoveKthNodeFromEnd(LinkedList head, int k)
        {
            // Write your code here.
            LinkedList fast = head;
            LinkedList slow = head;

            int counter = 0;
            while (counter < k)
            {
                fast = fast.Next;
                counter++;
            }
            if (fast == null)
            { // this means head is the one to remove
                head.Value = head.Next.Value;
                head.Next = head.Next.Next;
                return;
            }
            while (fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next;
            }
            slow.Next = slow.Next.Next;
        }

        public class LinkedList
        {
            public int Value;
            public LinkedList Next = null;

            public LinkedList(int value)
            {
                this.Value = value;
            }
        }
    }
}