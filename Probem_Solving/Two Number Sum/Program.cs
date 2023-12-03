namespace Two_Number_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] result = TwoNumberSum(new int[]{ 3, 5, -4, 8, 11, 1, -1, 6 }, 10);
            foreach(int i in result)
            {
                Console.WriteLine(i);
            }
        }

        public static int[] TwoNumberSum(int[] array, int targetSum)
        {
            // Write your code here.
            Dictionary<int, bool> dict = new Dictionary<int, bool>();
            for (int i = 0; i < array.Length; i++)
            {
                if (dict.ContainsKey(targetSum - array[i]))
                {
                    return new int[2] { array[i], targetSum - array[i] };
                }
                else
                {
                    dict.Add(array[i], true);
                }
            }
            return new int[0];
        }
    }
}