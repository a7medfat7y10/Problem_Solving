namespace Merge_Overlapping_Intervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MergeOverlappingIntervals(new int[][] {new int[] { 1, 2 }, new int[] { 3, 5 }, new int[] { 4, 9 } });
        }
        //O(nlog(n)) time / O(n) space
        public static int[][] MergeOverlappingIntervals(int[][] intervals)
        {
            // Write your code here.
            Array.Sort(intervals, (x, y) => x[0].CompareTo(y[0]));
            List<int[]> result = new List<int[]>();

            int[] ToAddInterval = intervals[0];
            result.Add(ToAddInterval);

            for (int i = 1; i < intervals.Length; i++)
            {
                if (intervals[i][0] > ToAddInterval[1])
                {
                    ToAddInterval = new int[] { intervals[i][0], intervals[i][1] };
                    result.Add(ToAddInterval);
                }
                else
                {
                    ToAddInterval[1] = Math.Max(intervals[i][1], ToAddInterval[1]);
                }
            }
            return result.ToArray();
        }
    }
}