namespace Find_Kth_Largest_Value_In_BST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Kth Largest Value In BST");
        }
        //O(n) time / O(n) space
        public int FindKthLargestValueInBst(BST tree, int k)
        {
            // Write your code here.
            List<int> treeValues = new List<int>();
            InOrderTraverse(tree, treeValues);
            return treeValues[treeValues.Count - k];
        }
        public void InOrderTraverse(BST node, List<int> treeValues)
        {
            if (node == null)
                return;
            InOrderTraverse(node.left, treeValues);
            treeValues.Add(node.value);
            InOrderTraverse(node.right, treeValues);
        }
        
        //Another Solution
        //O(h+k) time / O(h) space
        public int FindKthLargestValueInBstV2(BST tree, int k)
        {
            // Write your code here.
            TreeInfo info = new TreeInfo(0, -1);
            ReverseInOrderTraverse(tree, k, info);
            return info.latestNode;
        }
        public void ReverseInOrderTraverse(BST node, int k, TreeInfo info)
        {
            if (node == null || info.numOfVisits >= k)
                return;
            ReverseInOrderTraverse(node.right, k, info);
            if (info.numOfVisits < k)
            {
                info.numOfVisits++;
                info.latestNode = node.value;
                ReverseInOrderTraverse(node.left, k, info);
            }
        }
        public class TreeInfo
        {
            public int numOfVisits;
            public int latestNode;
            public TreeInfo(int n, int l)
            {
                this.numOfVisits = n;
                this.latestNode = l;
            }
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
    }
}