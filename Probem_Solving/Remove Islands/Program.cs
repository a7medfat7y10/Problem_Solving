namespace Remove_Islands
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = {
            new int[] {1, 1, 1, 1, 0},
            new int[] {1, 1, 0, 1, 0},
            new int[] {1, 1, 0, 0, 0},
            new int[] {0, 0, 0, 0, 0}
            };

            int[][] result = RemoveIslands(matrix);
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        //O(wh) time / O(wh) space
        public static int[][] RemoveIslands(int[][] matrix)
        {
            // Write your code here.
            bool[,] connectedToBorder = new bool[matrix.Length, matrix[0].Length];
            for (int i = 0; i < matrix.Length; i++)
            {
                connectedToBorder[i, matrix[0].Length - 1] = false;
            }
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    //not border
                    if (!(i == 0 || i == matrix.Length - 1 || j == 0 || j == matrix[i].Length - 1))
                        continue;
                    if (matrix[i][j] != 1)
                        continue;
                    findOnesConnectedToBorder(matrix, i, j, connectedToBorder);
                }
            }
            for (int i = 1; i < matrix.Length - 1; i++)
            {
                for (int j = 1; j < matrix[i].Length - 1; j++)
                {
                    if (connectedToBorder[i, j])
                        continue;
                    matrix[i][j] = 0;
                }
            }
            return matrix;
        }

        public static void findOnesConnectedToBorder(int[][] matrix, int row, int col, bool[,] connectedToBorder)
        {
            Stack<Tuple<int, int>> stack = new Stack<Tuple<int, int>>();
            stack.Push(new Tuple<int, int>(row, col));
            while (stack.Count > 0)
            {
                var current = stack.Pop();
                int currentRow = current.Item1;
                int currentCol = current.Item2;

                bool visited = connectedToBorder[currentRow, currentCol];
                if (visited)
                    continue;
                connectedToBorder[currentRow, currentCol] = true;

                var neighbours = getNeighbours(matrix, currentRow, currentCol);
                foreach (var neighbour in neighbours)
                {
                    int i = neighbour.Item1;
                    int j = neighbour.Item2;
                    if (matrix[i][j] != 1)
                        continue;
                    stack.Push(neighbour);
                }
            }
        }

        public static List<Tuple<int, int>> getNeighbours(int[][] matrix, int row, int col)
        {
            List<Tuple<int, int>> neighbours = new List<Tuple<int, int>>();
            if (row >= 1)
            {
                neighbours.Add(new Tuple<int, int>(row - 1, col));
            }
            if (row < matrix.Length - 1)
            {
                neighbours.Add(new Tuple<int, int>(row + 1, col));
            }
            if (col >= 1)
            {
                neighbours.Add(new Tuple<int, int>(row, col - 1));
            }
            if (col < matrix[row].Length - 1)
            {
                neighbours.Add(new Tuple<int, int>(row, col + 1));
            }
            return neighbours;
        }
    }
}