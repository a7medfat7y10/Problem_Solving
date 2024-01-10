namespace Branch_Sums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Branch Sums");
        }
        public class BinaryTree
        {
            public int value;
            public BinaryTree left;
            public BinaryTree right;

            public BinaryTree(int value)
            {
                this.value = value;
                this.left = null;
                this.right = null;
            }
        }
        //Recursive Solution O(n) time / O(n) space
        public static List<int> BranchSums(BinaryTree root)
        {
            // Write your code here.
            List<int> result = new List<int>();
            CalculateSumForNode(root, 0, result);
            return result;
        }
        public static void CalculateSumForNode(BinaryTree node, int sum, List<int> result)
        {
            int newSum = sum + node.value;
            if (node.left == null && node.right == null)
                result.Add(newSum);
            else
            {
                if (node.left != null)
                    CalculateSumForNode(node.left, newSum, result);
                if (node.right != null)
                    CalculateSumForNode(node.right, newSum, result);
            }
        }
    }
}