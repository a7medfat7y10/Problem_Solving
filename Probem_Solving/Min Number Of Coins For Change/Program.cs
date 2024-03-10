namespace Min_Number_Of_Coins_For_Change
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinNumberOfCoinsForChange(7, new int[] {1,5,10}));
        }
        //O(nd) time / O(n) space
        public static int MinNumberOfCoinsForChange(int n, int[] denoms)
        {
            // Write your code here.
            int[] numOfCoins = new int[n + 1];
            Array.Fill(numOfCoins, int.MaxValue);
            numOfCoins[0] = 0;
            foreach (int denom in denoms)
            {
                for (int i = 0; i <= n; i++)
                {
                    if (denom <= i)
                    {
                        if (numOfCoins[i - denom] == int.MaxValue)
                        {
                            numOfCoins[i] = Math.Min(numOfCoins[i], numOfCoins[i - denom]);
                        }
                        else
                        {
                            numOfCoins[i] = Math.Min(numOfCoins[i], numOfCoins[i - denom] + 1);
                        }
                    }
                }
            }
            if (numOfCoins[n] != int.MaxValue)
                return numOfCoins[n];
            return -1;
        }
    }
}