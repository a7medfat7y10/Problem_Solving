namespace Non_Constructible_Change
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NonConstructibleChange(new int[] { 1, 2, 5 })); 
        }
        //O(nlog(n)) time / O(1) space
        public static int NonConstructibleChange(int[] coins)
        {
            // Write your code here.
            Array.Sort(coins);

            int minChange = 0;

            for (int i = 0; i < coins.Length; i++)
            {
                if (coins[i] > minChange + 1)
                    return minChange + 1;

                minChange += coins[i];
            }
            return minChange + 1;
        }
    }
}