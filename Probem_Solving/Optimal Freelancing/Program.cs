namespace Optimal_Freelancing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> job1 = new Dictionary<string, int>();
            job1["deadline"] = 3;
            job1["payment"] = 1;
            Dictionary<string, int> job2 = new Dictionary<string, int>();
            job1["deadline"] = 4;
            job1["payment"] = 3;
            Dictionary<string, int>[] array = new Dictionary<string, int>[] { job1 , job2 };
            Console.WriteLine(OptimalFreelancing(array));
        }
        //O(nlog(n)) time / O(1) space
        //as the sorting is the heighst time complexity and the nested for loop doesnot loop more than 7 times max
        //and O(1) space as the result array size doesnot grow with the increase of the input.
        public static int OptimalFreelancing(Dictionary<string, int>[] jobs)
        {
            // Write your code here.
            int max_days = 7;
            //sort the jobs by payment
            Array.Sort(jobs, (a, b) => a["payment"].CompareTo(b["payment"]));

            int[] result = new int[max_days];
            //loop throught jobs from the heighst and 
            //check if its deadline is less than 7 days
            for (int i = jobs.Length - 1; i >= 0; i--)
            {
                //now we get the heighst index we can put the job in
                int index = (jobs[i]["deadline"] <= max_days) ? jobs[i]["deadline"] : max_days;
                //loop throught all the result array starting from the index to the beginnig
                //and search for the first available place
                for (int j = index - 1; j >= 0; j--)
                {
                    if (result[j] == 0)
                    {
                        result[j] = jobs[i]["payment"];
                        break;
                    }
                }
            }

            int maxprofit = 0;
            for (int i = 0; i < result.Length; i++)
            {
                maxprofit += result[i];
            }
            return maxprofit;
        }
    }
}