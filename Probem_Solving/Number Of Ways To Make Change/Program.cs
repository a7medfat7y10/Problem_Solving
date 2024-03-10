namespace Number_Of_Ways_To_Make_Change
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfWaysToMakeChange(6, new int[] { 1, 5 }));
        }
        //O(n) time / O(n) space
        public static int NumberOfWaysToMakeChange(int n, int[] denoms)
        {
            // Write your code here.
            int[] ways = new int[n + 1];
            ways[0] = 1;
            foreach (var denom in denoms)
            {
                //store at each amount i the number of ways that the denoms can make this amount
                for (int i = 1; i <= n; i++)
                {
                    if (denom <= i)
                    {
                        ways[i] += ways[i - denom];
                    }
                }
            }
            return ways[n];
        }
    }
}