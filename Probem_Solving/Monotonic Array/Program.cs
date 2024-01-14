namespace Monotonic_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsMonotonic(new int[] {1,4,4,3,2}));
        }
        //O(n) time / O(1) space
        public static bool IsMonotonic(int[] array)
        {
            // Write your code here.
            if (array.Length > 1)
            {
                int diff = array[0] - array[1];
                for (int i = 1; i < array.Length - 1; i++)
                {
                    if (diff == 0)
                    {
                        diff = array[i] - array[i + 1];
                        continue;
                    }
                    if (diff > 0 && array[i] - array[i + 1] < 0)
                        return false;
                    if (diff < 0 && array[i] - array[i + 1] > 0)
                        return false;
                }
            }
            return true;
        }
        public static bool IsMonotonicV2(int[] array)
        {
            // Write your code here.
            bool isNonDecreasing = true;
            bool isNonIncreasing = true;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                {
                    isNonDecreasing = false;
                }
                if (array[i] > array[i - 1])
                {
                    isNonIncreasing = false;
                }
            }

            return isNonDecreasing || isNonIncreasing;
        }
    }
}