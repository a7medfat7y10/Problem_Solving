namespace Remove_Duplicates_From_Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List");
        }
        // This is an input class. Do not edit.
        public class LinkedList
        {
            public int value;
            public LinkedList next;

            public LinkedList(int value)
            {
                this.value = value;
                this.next = null;
            }
        }

        public LinkedList RemoveDuplicatesFromLinkedList(LinkedList linkedList)
        {
            // Write your code here.
            LinkedList current = linkedList;
            while (current.next != null)
            {
                if (current.value == current.next.value)
                    current.next = current.next.next;
                else
                    current = current.next;
            }
            return linkedList;
        }
    }
}