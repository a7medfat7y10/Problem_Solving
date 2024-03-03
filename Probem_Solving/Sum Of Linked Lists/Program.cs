namespace Sum_Of_Linked_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum Of Linked Lists");
        }
        //O(n) time / O(n) space
        public LinkedList SumOfLinkedLists(
          LinkedList linkedListOne, LinkedList linkedListTwo
        )
        {
            // Write your code here.
            int sum = 0;
            int i = 1;
            while (linkedListOne != null)
            {
                sum += linkedListOne.value * i;
                i *= 10;
                linkedListOne = linkedListOne.next;
            }
            i = 1;
            while (linkedListTwo != null)
            {
                sum += linkedListTwo.value * i;
                i *= 10;
                linkedListTwo = linkedListTwo.next;
            }
            string sumStr = sum.ToString();
            LinkedList result = new LinkedList(Convert.ToInt32(sumStr[sumStr.Length - 1] - 48));
            LinkedList node = result;
            for (i = 1; i < sumStr.Length; i++)
            {
                node.next = new LinkedList(Convert.ToInt32(sumStr[sumStr.Length - 1 - i] - 48));
                node = node.next;
            }
            return result;
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
}