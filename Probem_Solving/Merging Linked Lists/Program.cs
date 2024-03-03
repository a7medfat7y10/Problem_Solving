namespace Merging_Linked_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merging Linked Lists");
        }
        //O(n+m) time / O(1) space 
        public LinkedList MergingLinkedLists(LinkedList linkedListOne, LinkedList linkedListTwo){
            // Write your code here.
            //pointer will traverse linkedlist one then two
            LinkedList ptr1 = linkedListOne;
            //pointer will traverse linkedlist two then one
            LinkedList ptr2 = linkedListTwo;
            while (ptr1 != ptr2)
            {
                if (ptr1 == null)
                    ptr1 = linkedListTwo;
                else
                    ptr1 = ptr1.next;
                if (ptr2 == null)
                    ptr2 = linkedListOne;
                else
                    ptr2 = ptr2.next;
            }
            return ptr1;
        }
    }
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
}