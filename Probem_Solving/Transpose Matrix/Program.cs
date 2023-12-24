namespace Transpose_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] transpose = TransposeMatrix(new int[,] { { 1, 2 }, { 3, 4 } });
            for (int i = 0; i < transpose.GetLength(0); i++)
            {
                for (int j = 0; j < transpose.GetLength(1); j++)
                {
                    Console.WriteLine( transpose[i, j]);
                }
            }
        }
        //O( i * j) time / O(n) space
        public static int[,] TransposeMatrix(int[,] matrix)
        {
            // Write your code here.
            int rows = matrix.GetLength(0);
            int cols = matrix.Length / matrix.GetLength(0);
            int[,] transpose = new int[cols, rows];

            for (int i = 0; i < transpose.GetLength(0); i++)
            {
                for (int j = 0; j < transpose.GetLength(1); j++)
                {
                    transpose[i, j] = matrix[j, i];
                }
            }
            return transpose;
        }
    }
}