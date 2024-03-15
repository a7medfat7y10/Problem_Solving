namespace River_Sizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = {
            {1, 0, 0, 1, 0},
            {1, 0, 1, 0, 0},
            {0, 0, 1, 0, 1},
            {1, 0, 1, 0, 1},
            {1, 0, 1, 1, 0}
            };

            List<int> riverSizes = RiverSizes(matrix);

            Console.WriteLine("Sizes of rivers:");
            foreach (int size in riverSizes)
            {
                Console.WriteLine(size);
            }
        }
        //O(wh) time / O(wh) space
        public static List<int> RiverSizes(int[,] matrix)
        {
            // Write your code here.
            List<int> sizes = new List<int>();
            bool[,] visited = new bool[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (visited[i, j] == true)
                        continue;
                    traverseNode(i, j, matrix, visited, sizes);
                }
            }
            return sizes;
        }
        public static void traverseNode(int i, int j, int[,] matrix, bool[,] visited, List<int> sizes)
        {
            int currentSize = 0;
            //BFS Traversal
            Stack<int[]> nodesToExplore = new Stack<int[]>();
            nodesToExplore.Push(new int[] { i, j });
            while (nodesToExplore.Count != 0)
            {
                int[] currentNode = nodesToExplore.Pop();
                i = currentNode[0];
                j = currentNode[1];
                if (visited[i, j])
                    continue;
                visited[i, j] = true;
                if (matrix[i, j] == 0)
                    continue;
                currentSize++;
                List<int[]> unvisitedNeighbours = getUnvisitedNeighbours(i, j, matrix, visited);
                foreach (var neighbour in unvisitedNeighbours)
                    nodesToExplore.Push(neighbour);
            }
            if (currentSize > 0)
                sizes.Add(currentSize);
        }
        public static List<int[]> getUnvisitedNeighbours(int i, int j, int[,] matrix, bool[,] visited)
        {
            List<int[]> unvisitedNeighbours = new List<int[]>();
            if (i > 0 && !visited[i - 1, j])
                unvisitedNeighbours.Add(new int[] { i - 1, j });
            if (i < matrix.GetLength(0) - 1 && !visited[i + 1, j])
                unvisitedNeighbours.Add(new int[] { i + 1, j });
            if (j > 0 && !visited[i, j - 1])
                unvisitedNeighbours.Add(new int[] { i, j - 1 });
            if (j < matrix.GetLength(1) - 1 && !visited[i, j + 1])
                unvisitedNeighbours.Add(new int[] { i, j + 1 });
            return unvisitedNeighbours;
        }
    }
}