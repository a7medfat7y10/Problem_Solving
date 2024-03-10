namespace Invert_Binary_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Invert Binary Tree");
        }
        //O(n) time / O(d) space where d is the depth
        public static void InvertBinaryTree(BinaryTree tree)
        {
            // Write your code here.
            if (tree == null)
                return;
            swap(tree);
            InvertBinaryTree(tree.left);
            InvertBinaryTree(tree.right);
        }
        //O(n) time / O(n) space
        public static void InvertBinaryTreeV2(BinaryTree tree)
        {
            // Write your code here.
            Queue<BinaryTree> q = new Queue<BinaryTree>();
            q.Enqueue(tree);
            while (q.Count != 0)
            {
                BinaryTree current = q.Dequeue();
                if (current == null)
                    continue;
                swap(current);
                if (current.left != null)
                    q.Enqueue(current.left);
                if (current.right != null)
                    q.Enqueue(current.right);
            }
        }
        public static void swap(BinaryTree tree)
        {
            BinaryTree temp = tree.left;
            tree.left = tree.right;
            tree.right = temp;
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