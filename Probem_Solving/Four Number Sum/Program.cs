namespace Four_Number_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int[]> result = FourNumberSum(new int[]{ 2, 4, 5, 3, 9, 10, 3, 5, 6}, 16);
            foreach (int[] result2 in result)
            {
                foreach (int num in result2) { 
                    Console.Write(num);
                }
                Console.WriteLine();
            }
        }
        public static List<int[]> FourNumberSum(int[] array, int targetSum)
        {
            // Write your code here.
            Dictionary<int, List<int[]>> allPairSums = new Dictionary<int, List<int[]>>();
            List<int[]> result = new List<int[]>();

            for (int i = 0; i < array.Length; i++)
            {

                for (int j = i + 1; j < array.Length; j++)
                {
                    int currentSum = array[i] + array[j];
                    int diff = targetSum - currentSum;
                    if (allPairSums.ContainsKey(diff))
                    {
                        foreach (int[] pair in allPairSums[diff])
                        {
                            result.Add(new int[] { array[i], array[j], pair[0], pair[1] });
                        }
                    }
                }

                for (int k = 0; k < i; k++)
                {
                    int currentSum = array[i] + array[k];
                    if (!allPairSums.ContainsKey(currentSum))
                    {
                        allPairSums.Add(currentSum, new List<int[]> { new int[] { array[k], array[i] } });
                    }
                    else
                        allPairSums[currentSum].Add(new int[] { array[k], array[i] });
                }
            }

            return result;
        }
    }
}