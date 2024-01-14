namespace Three_Number_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int[]> result = ThreeNumberSum(new int[] { 12, 3, 1, 2, -6, 5, -8, 6 }, 0);
            foreach (int[] value in result)
            {
                foreach(int v in value)
                {
                    Console.WriteLine(v);
                }
                    Console.WriteLine( "==========");
            }
        }
        //O(n^2) time / O(n) space
        public static List<int[]> ThreeNumberSum(int[] array, int targetSum)
        {
            // Write your code here.
            Array.Sort(array);
            List<int[]> result = new List<int[]>();
            for (int i = 0; i < array.Length - 2; i++)
            {
                int left = i + 1;
                int right = array.Length - 1;


                while (left < right)
                {
                    if (array[i] + array[left] + array[right] == targetSum)
                    {
                        result.Add(new int[] { array[i], array[left], array[right] });
                        left++;
                        right--;
                    }
                    else if (array[i] + array[left] + array[right] > targetSum)
                        right--;
                    else if (array[i] + array[left] + array[right] < targetSum)
                        left++;
                }
            }
            return result;
        }
    }
}