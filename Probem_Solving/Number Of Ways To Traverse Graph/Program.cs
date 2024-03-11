namespace Number_Of_Ways_To_Traverse_Graph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfWaysToTraverseGraph(3,4));
        }
        //O(n*m) time / O(n*m) space
        public static int NumberOfWaysToTraverseGraph(int width, int height)
        {
            // Write your code here.
            int[,] ways = new int[height + 1, width + 1];
            for (int i = 1; i < width + 1; i++)
            {
                for (int j = 1; j < height + 1; j++)
                {
                    if (i == 1 || j == 1)
                        ways[j, i] = 1;
                    else
                    {
                        ways[j, i] = ways[j, i - 1] + ways[j - 1, i];
                    }
                }
            }
            return ways[height, width];
        }
        //Another Solution using recursion
        //O(2(n+m)) time / O(n+m) space
        public static int NumberOfWaysToTraverseGraphV2(int width, int height)
        {
            // Write your code here.
            if (height == 1 || width == 1)
                return 1;
            return NumberOfWaysToTraverseGraph(width - 1, height) + NumberOfWaysToTraverseGraph(width, height - 1);
        }
    }
}