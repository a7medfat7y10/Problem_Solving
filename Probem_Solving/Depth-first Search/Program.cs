namespace Depth_first_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node a = new Node("A");
            Node b = a.AddChild("B");
            Node e = b.AddChild("E");
            Node f = b.AddChild("F");
            Node i = f.AddChild("I");
            Node j = f.AddChild("J");
            Node c = a.AddChild("C");
            Node d = a.AddChild("D");
            Node g = d.AddChild("G");
            Node k = g.AddChild("K");
            Node h = d.AddChild("H");

            List<string> result = new List<string>();
            a.DepthFirstSearch(result);
            foreach(string s in result)
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
            public List<string> DepthFirstSearch(List<string> array)
            {
                // Write your code here.
                array.Add(this.name);
                foreach (Node child in this.children)
                {
                    child.DepthFirstSearch(array);
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