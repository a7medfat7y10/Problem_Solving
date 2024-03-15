namespace Reconstruct_BST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reconstruct BST");
        }
        public class BST
        {
            public int value;
            public BST left = null;
            public BST right = null;

            public BST(int value)
            {
                this.value = value;
            }
        }

        public class TreeInfo
        {
            public int rootIndx;
            public TreeInfo(int i)
            {
                this.rootIndx = i;
            }
        }
        //O(n) time / O(n) space
        public BST ReconstructBst(List<int> preOrderTraversalValues)
        {
            // Write your code here.
            TreeInfo info = new TreeInfo(0);
            return ReconstructBst(preOrderTraversalValues, int.MinValue, int.MaxValue, info);
        }
        public BST ReconstructBst(List<int> preOrderTraversalValues, int lower, int upper, TreeInfo subTreeInfo)
        {
            // Write your code here.
            if (subTreeInfo.rootIndx == preOrderTraversalValues.Count)
                return null;
            int root = preOrderTraversalValues[subTreeInfo.rootIndx];
            if (root < lower || root >= upper)
                return null;

            subTreeInfo.rootIndx++;
            BST left = ReconstructBst(preOrderTraversalValues, lower, root, subTreeInfo);
            BST right = ReconstructBst(preOrderTraversalValues, root, upper, subTreeInfo);

            BST bst = new BST(root);
            bst.left = left;
            bst.right = right;

            return bst;
        }
    }
}