namespace Linked_List_Construction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Doubly Linked List");
        }
        public class DoublyLinkedList
        {
            public Node Head;
            public Node Tail;

            public void SetHead(Node node)
            {
                // Write your code here.
                if (Head == null)
                {
                    Head = Tail = node;
                    return;
                }
                InsertBefore(Head, node);
            }

            public void SetTail(Node node)
            {
                // Write your code here.
                if (Tail == null)
                {
                    SetHead(node);
                    return;
                }
                InsertAfter(Tail, node);
            }

            public void InsertBefore(Node node, Node nodeToInsert)
            {
                // Write your code here.
                if (nodeToInsert == Head && nodeToInsert == Tail)
                    return;
                Remove(nodeToInsert);
                nodeToInsert.Prev = node.Prev;
                nodeToInsert.Next = node;
                if (node.Prev == null)
                {
                    Head = nodeToInsert;
                }
                else
                {
                    node.Prev.Next = nodeToInsert;
                }
                node.Prev = nodeToInsert;
            }

            public void InsertAfter(Node node, Node nodeToInsert)
            {
                // Write your code here.
                if (nodeToInsert == Head && nodeToInsert == Tail)
                    return;
                Remove(nodeToInsert);
                nodeToInsert.Prev = node;
                nodeToInsert.Next = node.Next;
                if (node.Next == null)
                {
                    Tail = nodeToInsert;
                }
                else
                {
                    node.Next.Prev = nodeToInsert;
                }
                node.Next = nodeToInsert;
            }

            public void InsertAtPosition(int position, Node nodeToInsert)
            {
                // Write your code here.
                if (position == 1)
                {
                    SetHead(nodeToInsert);
                    return;
                }
                Node node = Head;
                int currentPosition = 1;
                while (node != null && currentPosition != position)
                {
                    node = node.Next;
                    currentPosition++;
                }
                if (node != null)
                {
                    InsertBefore(node, nodeToInsert);
                }
                else
                {
                    SetTail(nodeToInsert);
                }
            }

            public void RemoveNodesWithValue(int value)
            {
                // Write your code here.
                Node node = Head;
                while (node != null)
                {
                    Node nodeToRemove = node;
                    node = node.Next;
                    if (nodeToRemove.Value == value)
                        Remove(nodeToRemove);
                }
            }

            public void Remove(Node node)
            {
                // Write your code here.
                if (node == Head)
                    Head = Head.Next;
                if (node == Tail)
                    Tail = Tail.Prev;
                if (node.Prev != null)
                    node.Prev.Next = node.Next;
                if (node.Next != null)
                    node.Next.Prev = node.Prev;
                node.Prev = null;
                node.Next = null;
            }

            public bool ContainsNodeWithValue(int value)
            {
                // Write your code here.
                Node node = Head;
                while (node != null && node.Value != value)
                {
                    node = node.Next;
                }
                if (node != null)
                    return true;
                return false;
            }
        }

        // Do not edit the class below.
        public class Node
        {
            public int Value;
            public Node Prev;
            public Node Next;

            public Node(int value)
            {
                this.Value = value;
            }
        }
    }
}