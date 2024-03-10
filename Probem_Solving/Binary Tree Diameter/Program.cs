namespace Binary_Tree_Diameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Tree Diameter");
        }
        //O(n) time / O(h) space where h is the height of the tree
        public int BinaryTreeDiameter(BinaryTree tree)
        {
            // Write your code here.
            return getTreeInfo(tree).diameter;
        }

        public TreeInfo getTreeInfo(BinaryTree tree)
        {
            if (tree == null)
                return new TreeInfo(0, 0);
            TreeInfo leftTreeInfo = getTreeInfo(tree.left);
            TreeInfo rightTreeInfo = getTreeInfo(tree.right);

            int longestPath = leftTreeInfo.height + rightTreeInfo.height;
            int maxDiameter = Math.Max(leftTreeInfo.diameter, rightTreeInfo.diameter);
            int currentDiameter = Math.Max(longestPath, maxDiameter);
            int currentHeight = 1 + Math.Max(leftTreeInfo.height, rightTreeInfo.height);
            return new TreeInfo(currentDiameter, currentHeight);
        }
        public class TreeInfo
        {
            public int diameter;
            public int height;
            public TreeInfo(int diameter, int height)
            {
                this.diameter = diameter;
                this.height = height;
            }
        }

        public class BinaryTree
        {
            public int value;
            public BinaryTree left;
            public BinaryTree right;

            public BinaryTree(int value)
            {
                this.value = value;
            }
        }
    }
}