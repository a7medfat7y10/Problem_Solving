namespace Group_Anagrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> anagrams = groupAnagrams(new List<string>() { "foo", "ko", "ok", "flop", "lofp", "oof" });
            foreach(List<string> anagram in anagrams)
            {
                foreach(string word in anagram)
                {
                    Console.WriteLine(word);
                }
                Console.WriteLine("--");
            }
        }
        //O(W*nlog(n)) time / O(wn) space
        public static List<List<string>> groupAnagrams(List<string> words)
        {
            // Write your code here.
            Dictionary<string, List<string>> anagramsGroups = new Dictionary<string, List<string>>();
            foreach (string word in words)
            {
                string sortedWord = sortWord(word);
                if (anagramsGroups.ContainsKey(sortedWord))
                    anagramsGroups[sortedWord].Add(word);
                else
                    anagramsGroups[sortedWord] = new List<string>() { word };
            }
            return anagramsGroups.Values.ToList();
        }
        public static string sortWord(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Sort(charArray);
            string sortedStr = new String(charArray);
            return sortedStr;
        }
    }
}