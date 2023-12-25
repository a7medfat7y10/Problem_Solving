namespace Palindrome_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("absdsba"));
        }
        public static bool IsPalindrome(string str)
        {
            // Write your code here.
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}