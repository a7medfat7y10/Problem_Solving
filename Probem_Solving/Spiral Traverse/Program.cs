namespace Spiral_Traverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach(int i in SpiralTraverse(
                new int[4,4] { 
                { 1,  2 , 3,  4 },
                { 12, 13, 14, 5 } ,
                { 11, 16, 15, 6 },
                { 10, 9,  8,  7}}))
            {
                Console.WriteLine(i);
            }
        }
        //O(n) time /O(n) space : n is the total number of elements in the array
        public static List<int> SpiralTraverse(int[,] array)
        {
            // Write your code here.
            List<int> result = new List<int>();
            if (array.GetLength(0) == 0) return result;
            int firstRow = 0;
            int lastRow = array.GetLength(0) - 1;
            int firstCol = 0;
            int lastCol = array.GetLength(1) - 1;

            while (firstRow <= lastRow && firstCol <= lastCol)
            {
                for (int i = firstCol; i <= lastCol; i++)
                {
                    result.Add(array[firstRow, i]);
                }
                for (int i = firstRow + 1; i <= lastRow; i++)
                {
                    result.Add(array[i, lastCol]);
                }
                for (int i = lastCol - 1; i >= firstCol && lastRow != firstRow; i--)
                {
                    result.Add(array[lastRow, i]);
                }
                for (int i = lastRow - 1; i > firstRow && lastCol != firstCol; i--)
                {
                    result.Add(array[i, firstCol]);
                }
                firstRow++;
                firstCol++;
                lastRow--;
                lastCol--;
            }
            return result;
        }
    }
}