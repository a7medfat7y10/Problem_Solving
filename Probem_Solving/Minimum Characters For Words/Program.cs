namespace Minimum_Characters_For_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var c in MinimumCharactersForWords(new string[] { "this", "that", "did", "ch" }))
            {
                Console.WriteLine(c);
            }
        }
        //O(n*l) time / O(c) space
        public static string[] MinimumCharactersForWords(string[] words)
        {
            // Dictionary to store the maximum character frequencies
            Dictionary<char, int> maximumCharFreq = new Dictionary<char, int>();

            foreach (var word in words)
            {
                // Dictionary to count each character in the words
                Dictionary<char, int> characterFreqInWord = new Dictionary<char, int>();

                // Count characters in the word
                foreach (var c in word)
                {
                    if (characterFreqInWord.ContainsKey(c))
                        characterFreqInWord[c]++;
                    else
                        characterFreqInWord[c] = 1;
                }

                // Update the maximum frequencies
                foreach (var entry in characterFreqInWord)
                {
                    char c = entry.Key;
                    int freq = entry.Value;
                    if (maximumCharFreq.ContainsKey(c))
                        maximumCharFreq[c] = Math.Max(freq, maximumCharFreq[c]);
                    else
                        maximumCharFreq[c] = freq;
                }
            }

            // Construct the result array
            List<string> result = new List<string>();
            foreach (var entry in maximumCharFreq)
            {
                char c = entry.Key;
                int freq = entry.Value;
                for (int i = 0; i < freq; i++)
                    result.Add(c.ToString());
            }
            return result.ToArray();
        }
    }
}