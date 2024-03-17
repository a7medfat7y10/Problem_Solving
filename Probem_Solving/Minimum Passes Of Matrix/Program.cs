namespace Minimum_Passes_Of_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinimumPassesOfMatrix(new int[][]
            {
                new int[] {0,-2,-1},
                new int[] {-5,2,0},
                new int[] {-6,-2,0},
            }));
        }
        //O(w*h) time / O(w*h) space
        public static int MinimumPassesOfMatrix(int[][] matrix)
        {
            // Write your code here.
            int passes = convertNegatives(matrix);
            if (!containsNegative(matrix))
                return passes - 1;
            return -1;
        }
        public static int convertNegatives(int[][] matrix)
        {
            List<int[]> nextQueue = getAllPositivePositions(matrix);
            int passes = 0;
            while (nextQueue.Count > 0)
            {
                List<int[]> currentQueue = nextQueue;
                nextQueue = new List<int[]>();
                while (currentQueue.Count > 0)
                {
                    int[] vals = currentQueue[0];
                    currentQueue.RemoveAt(0);

                    int currentRow = vals[0];
                    int currentCol = vals[1];
                    List<int[]> adjacentPositions = getAdjacentPositions(currentRow, currentCol, matrix);
                    foreach (var position in adjacentPositions)
                    {
                        int row = position[0];
                        int col = position[1];
                        int value = matrix[row][col];
                        if (value < 0)
                        {
                            matrix[row][col] *= -1;
                            nextQueue.Add(new int[] { row, col });
                        }
                    }
                }
                passes++;
            }
            return passes;
        }

        public static List<int[]> getAllPositivePositions(int[][] matrix)
        {
            List<int[]> positivePositions = new List<int[]>();
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    int value = matrix[row][col];
                    if (value > 0)
                        positivePositions.Add(new int[] { row, col });
                }
            }
            return positivePositions;
        }
        public static List<int[]> getAdjacentPositions(int row, int col, int[][] matrix)
        {
            List<int[]> adjacentPositions = new List<int[]>();
            if (row > 0)
                adjacentPositions.Add(new int[] { row - 1, col });
            if (row < matrix.Length - 1)
                adjacentPositions.Add(new int[] { row + 1, col });
            if (col > 0)
                adjacentPositions.Add(new int[] { row, col - 1 });
            if (col < matrix[0].Length - 1)
                adjacentPositions.Add(new int[] { row, col + 1 });

            return adjacentPositions;
        }
        public static bool containsNegative(int[][] matrix)
        {
            foreach (var row in matrix)
            {
                foreach (var value in row)
                {
                    if (value < 0)
                        return true;
                }
            }
            return false;
        }
    }
}