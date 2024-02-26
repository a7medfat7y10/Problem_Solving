namespace Longest_Palindromic_Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestPalindromicSubstring("abaxyzzyxf"));
        }
        //O(n^3) time / O(n)space
        public static string LongestPalindromicSubstring(string str)
        {
            // Write your code here.
            string longestPalindrome = "";
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i; j < str.Length; j++)
                {
                    string newStr = str.Substring(i, j - i + 1);
                    if (newStr.Length > longestPalindrome.Length && isPalindrome(newStr))
                        longestPalindrome = newStr;
                }
            }
            return longestPalindrome;
        }

        public static bool isPalindrome(string str)
        {
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - i - 1])
                    return false;
            }
            return true;
        }

        //Another Solution
        //O(n^2) time/ O(n) space
        public static string LongestPalindromicSubstringV2(string str)
        {
            // Write your code here.
            int[] currentLongest = { 0, 1 };
            for (int i = 1; i < str.Length; i++)
            {
                //checking if the char at i is the middle of odd palindrome ex: ama
                int[] odd = getLongestPalindormeFrom(str, i - 1, i + 1);
                int oddLength = odd[1] - odd[0];
                //checking if the char at i is in the middle of even palindrome ex: aa
                int[] even = getLongestPalindormeFrom(str, i - 1, i);
                int evenLength = even[1] - even[0];
                int[] longest = oddLength > evenLength ? odd : even;

                currentLongest = currentLongest[1] - currentLongest[0] > longest[1] - longest[0] ? currentLongest : longest;
            }
            return str.Substring(currentLongest[0], currentLongest[1] - currentLongest[0]);
        }
        public static int[] getLongestPalindormeFrom(string str, int leftIndx, int rightIndx)
        {
            while (leftIndx >= 0 && rightIndx < str.Length)
            {
                if (str[leftIndx] != str[rightIndx])
                    break;
                leftIndx--;
                rightIndx++;
            }
            return new int[] { leftIndx + 1, rightIndx };
        }
    }
}