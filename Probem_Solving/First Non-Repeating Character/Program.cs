using System.Collections.Generic;

namespace First_Non_Repeating_Character
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstNonRepeatingCharacter("ahmmead"));
        }
        //O(n) time / O(1) space
        public static int FirstNonRepeatingCharacter(string str)
        {
            // Write your code here.
            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (counts.ContainsKey(c))
                    counts[c] += 1;
                else
                    counts[c] = 1;
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (counts[str[i]] == 1)
                    return i;
            }

            return -1;
        }
    }
}