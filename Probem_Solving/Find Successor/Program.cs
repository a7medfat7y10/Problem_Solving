namespace Find_Successor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Successor");
        }
        public class BinaryTree
        {
            public int value;
            public BinaryTree left = null;
            public BinaryTree right = null;
            public BinaryTree parent = null;

            public BinaryTree(int value)
            {
                this.value = value;
            }
        }
        //O(n) time / O(n) space
        public BinaryTree FindSuccessor(BinaryTree tree, BinaryTree node)
        {
            // Write your code here.
            List<BinaryTree> nodesListInOrder = new List<BinaryTree>();
            getNodesListInOrder(tree, nodesListInOrder);

            for (int i = 0; i < nodesListInOrder.Count - 1; i++)
            {
                BinaryTree current = nodesListInOrder[i];
                if (current.value == node.value)
                    return nodesListInOrder[i + 1];
            }
            return null;
        }
        public void getNodesListInOrder(BinaryTree node, List<BinaryTree> list)
        {
            if (node == null)
            {
                return;
            }
            getNodesListInOrder(node.left, list);
            list.Add(node);
            getNodesListInOrder(node.right, list);
        }
        //Another Solution
        //O(h) time / O(1) space
        public BinaryTree FindSuccessorV2(BinaryTree tree, BinaryTree node)
        {
            // Write your code here.
            //the node successor will be always the left most node in the right sub tree    
            if (node.right != null)
                return getLeftmostChild(node.right);
            return getRightmostParent(node);
        }
        public BinaryTree getLeftmostChild(BinaryTree node)
        {
            BinaryTree current = node;
            while (current.left != null)
                current = current.left;
            return current;
        }
        public BinaryTree getRightmostParent(BinaryTree node)
        {
            BinaryTree current = node;
            while (current.parent != null && current.parent.right == current)
                current = current.parent;
            return current.parent;
        }
    }
}