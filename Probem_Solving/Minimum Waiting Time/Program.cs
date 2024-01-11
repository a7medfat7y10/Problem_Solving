namespace Minimum_Waiting_Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] queries = new int[] { 1, 4, 5, 3, 2 };
            Console.WriteLine(MinimumWaitingTime(queries));
        }
        //O(nlog(n)) time / O(1) space
        public static int MinimumWaitingTime(int[] queries)
        {
            // Write your code here.
            int waitingTime = 0;
            int sumToNum = 0;
            Array.Sort(queries);
            for (int i = 0; i < queries.Length - 1; i++)
            {
                sumToNum += queries[i];
                waitingTime += sumToNum;
            }

            return waitingTime;
        }
    }
}