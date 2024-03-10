namespace Merge_Binary_Trees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merge Binary Trees");
        }
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
        //O(n) time / O(h) space
        public BinaryTree MergeBinaryTrees(BinaryTree tree1, BinaryTree tree2)
        {
            // Write your code here.
            if (tree1 == null)
                return tree2;
            if (tree2 == null)
                return tree1;
            tree1.value += tree2.value;
            tree1.left = MergeBinaryTrees(tree1.left, tree2.left);
            tree1.right = MergeBinaryTrees(tree1.right, tree2.right);

            return tree1;
            return null;
        }
    }
}