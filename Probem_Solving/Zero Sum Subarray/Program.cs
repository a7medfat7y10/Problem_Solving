namespace Zero_Sum_Subarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ZeroSumSubarray(new int[] {1,4,4,3,0,1,2}));
        }
        //O(n) time / O(n) space
        public static bool ZeroSumSubarray(int[] nums)
        {
            // Write your code here.
            HashSet<int> sums = new HashSet<int>();
            int sum = 0;
            //adding zero to the array of sums
            sums.Add(sum);
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                //if sums have the current sum it shows that either the sums of all the elements
                //to this number is zero or that the sum has been repeated before so some of the 
                //elements sum to 0
                if (sums.Contains(sum))
                {
                    return true;
                }
                sums.Add(sum);
            }
            return false;
        }
    }
}