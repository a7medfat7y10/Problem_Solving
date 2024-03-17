namespace Two_Colorable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TwoColorable(new int[][]
            {
                new int[]{1,2 },
                new int[]{0,2 },
                new int[]{0,1 }
            }));
        }
        //O(v+e) time / O(v) space
        public static bool TwoColorable(int[][] edges)
        {
            // Write your code here.
            int[] colors = new int[edges.Length];
            colors[0] = 1;
            Stack<int> stack = new Stack<int>();
            stack.Push(0);

            while (stack.Count > 0)
            {
                int currentNode = stack.Pop();
                foreach (var edge in edges[currentNode])
                {
                    if (colors[edge] == 0)
                    {
                        if (colors[currentNode] == 1)
                            colors[edge] = 2;
                        else
                            colors[edge] = 1;
                        stack.Push(edge);
                    }
                    else if (colors[edge] == colors[currentNode])
                        return false;
                }
            }
            return true;
        }
    }
}