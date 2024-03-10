namespace Symmetrical_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Symmetrical Tree");
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
        //O(n) time / O(h) space
        public bool SymmetricalTree(BinaryTree tree)
        {
            // Write your code here.
            return isSymmetrical(tree.left, tree.right);
        }

        public bool isSymmetrical(BinaryTree left, BinaryTree right)
        {
            if (left != null && right != null && left.value == right.value)
            {
                return isSymmetrical(left.left, right.right) &&
                    isSymmetrical(right.left, left.right);
            }
            return left == right;
        }
    }
}