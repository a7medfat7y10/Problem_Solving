namespace Missing_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] result = MissingNumbers(new int[] { 1, 4, 3 });
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }
        //O(n) time / O(1) space
        public static int[] MissingNumbers(int[] nums)
        {
            // Write your code here.
            int sumOfTwoMissing = 0;
            for (int i = 0; i < nums.Length + 3; i++)
            {
                sumOfTwoMissing += i;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                sumOfTwoMissing -= nums[i];
            }
            int avgOfTwoMissing = sumOfTwoMissing / 2;

            int sumLowerValues = 0;
            int sumHigherValues = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] <= avgOfTwoMissing)
                    sumLowerValues += nums[i];
                else
                    sumHigherValues += nums[i];
            }

            int sumLowerValuesExpected = 0;
            int sumHigherValuesExpected = 0;
            for (int i = 0; i < nums.Length + 3; i++)
            {
                if (i <= avgOfTwoMissing)
                    sumLowerValuesExpected += i;
                else
                    sumHigherValuesExpected += i;
            }
            return new int[] { sumLowerValuesExpected - sumLowerValues, sumHigherValuesExpected - sumHigherValues };
        }
    }
}