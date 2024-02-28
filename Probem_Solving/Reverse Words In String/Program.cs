namespace Reverse_Words_In_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseWordsInString("Hello, World!"));
        }
        //O(n) time / O(n) space
        public static string ReverseWordsInString(string str)
        {
            // Write your code here.
            List<string> words = new List<string>();
            int startOfWord = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    words.Add(str.Substring(startOfWord, i - startOfWord));
                    startOfWord = i;
                }
                else if (str[startOfWord] == ' ')
                {
                    words.Add(" ");
                    startOfWord = i;
                }
            }
            //add the last word
            words.Add(str.Substring(startOfWord));

            words.Reverse();

            string word = "";
            foreach (string w in words)
            {
                word += w;
            }
            return word;
        }
    }
}