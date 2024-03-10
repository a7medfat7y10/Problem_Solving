namespace Height_Balanced_Binary_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Height Balanced Binary Tree");
        }
        // This is an input class. Do not edit.
        public class BinaryTree
        {
            public int value;
            public BinaryTree left = null;
            public BinaryTree right = null;

            public BinaryTree(int value)
            {
                this.value = value;
            }
        }
        public class TreeInfo
        {
            public bool isBalanced;
            public int height;
            public TreeInfo(bool isBalanced, int height)
            {
                this.isBalanced = isBalanced;
                this.height = height;
            }
        }
        //O(n) time / O(h) space
        public bool HeightBalancedBinaryTree(BinaryTree tree)
        {
            // Write your code here.
            return getTreeInfo(tree).isBalanced;
        }
        public TreeInfo getTreeInfo(BinaryTree node)
        {
            if (node == null)
                return new TreeInfo(true, -1);
            TreeInfo left = getTreeInfo(node.left);
            TreeInfo right = getTreeInfo(node.right);

            bool isBalanced = left.isBalanced && right.isBalanced && Math.Abs(left.height - right.height) <= 1;
            int height = Math.Max(left.height, right.height) + 1;
            return new TreeInfo(isBalanced, height);
        }
    }
}