namespace Max_Subset_Sum_No_Adjacent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxSubsetSumNoAdjacent(new int[] {3,4,2,7,9,12,2,13}));
        }
        //O(n) time / O(n) space
        public static int MaxSubsetSumNoAdjacent(int[] array)
        {
            // Write your code here.
            if (array.Length == 0)
            {
                return 0;
            }
            else if (array.Length == 1)
            {
                return array[0];
            }
            int[] maxSums = new int[array.Length];
            maxSums[0] = array[0];
            maxSums[1] = Math.Max(array[0], array[1]);
            for (int i = 2; i < array.Length; i++)
            {
                maxSums[i] = Math.Max(maxSums[i - 1], maxSums[i - 2] + array[i]);
            }
            return maxSums[array.Length - 1];
        }
        //O(n) time / O(1) space
        public static int MaxSubsetSumNoAdjacentV2(int[] array)
        {
            // Write your code here.
            if (array.Length == 0)
            {
                return 0;
            }
            else if (array.Length == 1)
            {
                return array[0];
            }
            int first = array[0];
            int second = Math.Max(array[0], array[1]);
            for (int i = 2; i < array.Length; i++)
            {
                int current = Math.Max(second, first + array[i]);
                first = second;
                second = current;
            }
            return second;
        }
    }
}