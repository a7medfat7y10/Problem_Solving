namespace Validate_BST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Validate BST");
        }
        //O(n) time / O(h) space
        public static bool ValidateBst(BST tree)
        {
            // Write your code here.
            return ValidateBst(tree, int.MinValue, int.MaxValue);
        }

        public static bool ValidateBst(BST tree, int min, int max)
        {
            if (tree == null)
                return true;
            return
                ValidateBst(tree.left, min, tree.value) &&
                ValidateBst(tree.right, tree.value, max) &&
                tree.value >= min && tree.value < max;
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