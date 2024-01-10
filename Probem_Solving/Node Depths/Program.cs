namespace Node_Depths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Node Depths");
        }
        //Recursive Solution
        public static int NodeDepths(BinaryTree root, int depth = 0)
        {
            // Write your code here.
            if (root == null)
                return 0;
            else
                return depth + NodeDepths(root.left, depth + 1) + NodeDepths(root.right, depth + 1);
        }

        //Iterative Solution
        //public static int NodeDepths(BinaryTree root)
        //{
        //    // Write your code here. 
        //    //BFS Solution
        //    var q = new Queue<(BinaryTree node, int depth)>();
        //    q.Enqueue((root, 0));
        //    int depthSum = 0;
        //    while (q.Count > 0)
        //    {
        //        var currentPair = q.Dequeue();
        //        int currentDepth = currentPair.depth + 1;
        //        if (currentPair.node.left != null)
        //        {
        //            q.Enqueue((currentPair.node.left, currentDepth));
        //            depthSum += currentDepth;
        //        }
        //        if (currentPair.node.right != null)
        //        {
        //            q.Enqueue((currentPair.node.right, currentDepth));
        //            depthSum += currentDepth;
        //        }
        //    }
        //    return depthSum;
        //}

        public class BinaryTree
        {
            public int value;
            public BinaryTree left;
            public BinaryTree right;

            public BinaryTree(int value)
            {
                this.value = value;
                left = null;
                right = null;
            }
        }
    }
}