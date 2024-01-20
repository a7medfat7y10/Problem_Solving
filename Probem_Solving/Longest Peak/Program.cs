namespace longest_Peak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestPeak(new int[] {2,4,5,6,8,4,3}));
        }
        public static int LongestPeak(int[] array)
        {
            // Write your code here.
            int longestLength = 0;
            int leftLength = 1;
            int rightLength = 1;

            for (int i = 1; i < array.Length - 1; i++)
            {
                //if not peak
                if (!(array[i] > array[i - 1] && array[i] > array[i + 1]))
                {
                    continue;
                }
                leftLength = 1;
                rightLength = 1;
                for (int left = i - 2; left >= 0 && array[left] < array[left + 1]; left--)
                {
                    leftLength++;
                }
                for (int right = i + 2; right < array.Length && array[right] < array[right - 1]; right++)
                {
                    rightLength++;
                }
                if (rightLength + leftLength + 1 > longestLength)
                {
                    longestLength = rightLength + leftLength + 1;
                }
            }

            return longestLength;
        }
    }
}