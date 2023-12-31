namespace Binary_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BinarySearch(new int[] {1,2,5,4,7} , 3));
        }
        public static int BinarySearch(int[] array, int target)
        {
            // Write your code here.
            int start = 0;
            int end = array.Length - 1;

            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (target == array[mid])
                    return mid;
                else if (target > array[mid])
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return -1;
        }
    }
}