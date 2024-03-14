namespace BST_Traversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BST Traversal");
        }
        //O(n) time / O(n) space
        public static List<int> InOrderTraverse(BST tree, List<int> array)
        {
            // Write your code here.
            if (tree.left != null)
                InOrderTraverse(tree.left, array);

            array.Add(tree.value);

            if (tree.right != null)
                InOrderTraverse(tree.right, array);
            return array;
        }

        public static List<int> PreOrderTraverse(BST tree, List<int> array)
        {
            // Write your code here.
            array.Add(tree.value);

            if (tree.left != null)
                PreOrderTraverse(tree.left, array);

            if (tree.right != null)
                PreOrderTraverse(tree.right, array);
            return array;
        }

        public static List<int> PostOrderTraverse(BST tree, List<int> array)
        {
            // Write your code here.
            if (tree.left != null)
                PostOrderTraverse(tree.left, array);

            if (tree.right != null)
                PostOrderTraverse(tree.right, array);

            array.Add(tree.value);
            return array;
        }

        public class BST
        {
            public int value;
            public BST left;
            public BST right;

            public BST(int value)
            {
                this.value = value;
            }
        }
    }
}