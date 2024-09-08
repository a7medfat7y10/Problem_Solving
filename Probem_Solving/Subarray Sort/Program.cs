namespace Subarray_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] result = SubarraySort(new int[] {1,2,4,7,10,11,7,12,6,6,16,18,19});
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }
        public static int[] SubarraySort(int[] array)
        {
            // Write your code here.
            int maxOutOfOrder = int.MinValue;
            int minOutOfOrder = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (isOutOfOrder(i, array))
                {
                    if (array[i] < minOutOfOrder)
                        minOutOfOrder = array[i];
                    if (array[i] > maxOutOfOrder)
                        maxOutOfOrder = array[i];
                }
            }

            if (minOutOfOrder == int.MaxValue)
                return new int[] { -1, -1 };

            int left = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > minOutOfOrder)
                {
                    left = i;
                    break;
                }
            }
            int right = array.Length - 1;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] < maxOutOfOrder)
                {
                    right = i;
                    break;
                }
            }

            return new int[] { left, right };
        }
        public static bool isOutOfOrder(int idx, int[] array)
        {
            if (idx == 0)
                return array[idx] > array[idx + 1];
            if (idx == array.Length - 1)
                return array[idx] < array[idx - 1];
            return array[idx] > array[idx + 1] || array[idx] < array[idx - 1];
        }
    }
}