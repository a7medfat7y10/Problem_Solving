namespace Find_Closest_Value_In_BST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Closest Value In BST");
        }
        //Iterative Solution (BFS)
        public static int FindClosestValueInBst(BST tree, int target)
        {
            // Write your code here.
            Queue<BST> q = new Queue<BST>();
            int minDiff = int.MaxValue;
            int closestValue = 0;
            q.Enqueue(tree);

            while (q.Count > 0)
            {
                BST currentNode = q.Dequeue();
                if (currentNode.left != null)
                    q.Enqueue(currentNode.left);
                if (currentNode.right != null)
                    q.Enqueue(currentNode.right);

                int currentDiff =
                    (currentNode.value > target) ? (currentNode.value - target) : (target - currentNode.value);
                if (currentDiff < minDiff)
                {
                    minDiff = currentDiff;
                    closestValue = currentNode.value;
                }
            }
            return closestValue;
        }

        //Another Solution (Recursive)
        public static int FindClosestValueInBstV2(BST tree, int target)
        {
            // Write your code here.
            return FindClosestValueInBstV2(tree, target, tree);
        }
        public static int FindClosestValueInBstV2(BST tree, int target, BST closestNode)
        {
            if (target == tree.value)
                return tree.value;
            if (Math.Abs(closestNode.value - target) > Math.Abs(tree.value - target))
                closestNode = tree;
            if (target < tree.value && tree.left != null)
                return FindClosestValueInBstV2(tree.left, target, closestNode);
            if (target > tree.value && tree.right != null)
                return FindClosestValueInBstV2(tree.right, target, closestNode);
            return closestNode.value;
        }

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