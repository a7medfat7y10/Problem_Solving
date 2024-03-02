namespace StaircaseTraversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StaircaseTraversalV2(4,2));
        }
        //O(k^n) time where k is maxSteps / O(n) space
        public static int StaircaseTraversal(int height, int maxSteps)
        {
            // Write your code here.
            if (height <= 1)
                return 1;
            int numOfWays = 0;
            for (int i = 1; i < Math.Min(maxSteps, height) + 1; i++)
            {
                numOfWays += StaircaseTraversal(height - i, maxSteps);
            }
            return numOfWays;
        }
        //iterative solution using dynamic programming
        //O(n) time / O(n) space
        public static int StaircaseTraversalV2(int height, int maxSteps)
        {
            // Write your code here.
            int[] ways = new int[height + 1];
            ways[0] = 1;
            ways[1] = 1;
            for (int i = 2; i < height + 1; i++)
            {
                for (int j = 1; j < Math.Min(maxSteps, i) + 1; j++)
                {
                    ways[i] = ways[i] + ways[i - j];
                }
            }
            return ways[height];
        }
    }
}