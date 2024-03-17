namespace Kadane_s_Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(KadanesAlgorithm(new int[] {3,5,-9,4,3,2,-3,-7,9,-5,8,4,-2}));
        }
        //O(n) time / O(1) space
        public static int KadanesAlgorithm(int[] array)
        {
            // Write your code here.
            int max = array[0];
            int maxSoFar = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                int num = array[i];
                max = Math.Max(num, num + max);
                maxSoFar = Math.Max(maxSoFar, max);
            }
            return maxSoFar;
        }
    }
}