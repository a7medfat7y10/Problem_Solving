namespace Split_Binary_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Split Binary Tree");
        }
        //O(n) time / O(h) space
        public int SplitBinaryTree(BinaryTree tree)
        {
            // Write your code here.
            int treeSum = getTreeSum(tree);
            if (treeSum % 2 != 0)
                return 0;
            bool canBeSplit = IsSubTreeSplittable(tree, treeSum / 2).canBeSplit;
            return canBeSplit == true ? treeSum / 2 : 0;
        }
        public ResultPair IsSubTreeSplittable(BinaryTree tree, int targetSum)
        {
            if (tree == null)
                return new ResultPair(0, false);

            ResultPair left = IsSubTreeSplittable(tree.left, targetSum);
            ResultPair right = IsSubTreeSplittable(tree.right, targetSum);

            int currentTreeSum = tree.value + left.currentTreeSum + right.currentTreeSum;
            bool canBeSplit = left.canBeSplit || right.canBeSplit || currentTreeSum == targetSum;
            return new ResultPair(currentTreeSum, canBeSplit);
        }
        int getTreeSum(BinaryTree tree)
        {
            if (tree == null)
                return 0;
            return tree.value + getTreeSum(tree.left) + getTreeSum(tree.right);
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
        public class ResultPair
        {
            public int currentTreeSum;
            public bool canBeSplit;
            public ResultPair(int currentTreeSum, bool canBeSplit)
            {
                this.currentTreeSum = currentTreeSum;
                this.canBeSplit = canBeSplit;
            }
        }
    }
}