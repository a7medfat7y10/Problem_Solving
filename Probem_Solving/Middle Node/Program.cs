namespace Middle_Node
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List 2");
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
        //O(n) time/ O(1) space
        public LinkedList MiddleNode(LinkedList linkedList)
        {
            // Write your code here.
            int count = 0;
            LinkedList current = linkedList;
            while (current.next != null)
            {
                count++;
                current = current.next;
            }
            int mid = (count + 1) / 2;
            count = 0;
            while (count < mid)
            {
                linkedList = linkedList.next;
                count++;
            }
            return linkedList;
        }
        //O(n) time/ O(1) space
        public LinkedList MiddleNodeV2(LinkedList linkedList)
        {
            // Write your code here.
            LinkedList current = linkedList;
            LinkedList twiceCurrent = linkedList;
            while (twiceCurrent != null && twiceCurrent.next != null)
            {
                current = current.next;
                twiceCurrent = twiceCurrent.next.next;
            }
            return current;
        }
    }
}