namespace Validate_Subsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                IsValidSubsequence(
                    new List<int>() { 5, 1, 22, 25, 6, -1, 8, 10},
                    new List<int>() { 1,6,-1,10}
                )
            );
        }
        public static bool IsValidSubsequence(List<int> array, List<int> sequence)
        {
            // Write your code here.
            int j = 0;
            for (int i = 0; i < array.Count && j < sequence.Count; i++)
            {
                if (array[i] == sequence[j])
                {
                    j++;
                }
            }
            if (j == sequence.Count)
                return true;
            return false;
        }
    }
}