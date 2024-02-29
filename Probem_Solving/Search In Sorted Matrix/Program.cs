namespace Search_In_Sorted_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (int num in SearchInSortedMatrix(new int[,] { { 1,2,3} , { 4,5,6} , { 7,8,9} } , 4))
            {
                Console.WriteLine(num);
            }
        }
        //O(n) time/ O(1) space
        public static int[] SearchInSortedMatrix(int[,] matrix, int target)
        {
            // Write your code here.
            int row = matrix.GetLength(0) - 1;
            int col = 0;
            while (row >= 0 && col <= matrix.GetLength(1) - 1)
            {
                if (matrix[row, col] > target)
                    row--;
                else if (matrix[row, col] < target)
                    col++;
                else
                    return new int[] { row, col };
            }
            return new int[] { -1, -1 };
        }
    }
}