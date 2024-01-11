namespace Breadth_first_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node a = new Node("A");
            Node b = a.AddChild("B");
            Node c = a.AddChild("C");
            Node d = a.AddChild("D");
            Node e = b.AddChild("E");
            Node f = b.AddChild("F");
            Node g = d.AddChild("G");
            Node h = d.AddChild("H");
            Node i = f.AddChild("I");
            Node j = f.AddChild("J");
            Node k = g.AddChild("K");

            List<string> result = new List<string>();
            a.BreadthFirstSearch(result);
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }
        public class Node
        {
            public string name;
            public List<Node> children = new List<Node>();

            public Node(string name)
            {
                this.name = name;
            }


            //O(v+e) time / O(v) space
            public List<string> BreadthFirstSearch(List<string> array)
            {
                // Write your code here.
                Queue<Node> q = new Queue<Node>();
                q.Enqueue(this);
                while (q.Count > 0)
                {
                    Node currentNode = q.Dequeue();
                    array.Add(currentNode.name);
                    foreach (Node child in currentNode.children)
                    {
                        q.Enqueue(child);
                    }
                }
                return array;
            }

            public Node AddChild(string name)
            {
                Node child = new Node(name);
                children.Add(child);
                return this;
            }
        }
    }
}