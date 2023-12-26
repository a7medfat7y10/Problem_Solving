namespace Generate_Document
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GenerateDocument("ahmed", "dameh"));
        }

        //O(n) time / O(c) space
        public static bool GenerateDocument(string characters, string document)
        {
            // Write your code here.
            Dictionary<char, int> CountsInCharacters = new Dictionary<char, int>();

            foreach (var c in characters)
            {
                if (CountsInCharacters.ContainsKey(c))
                {
                    CountsInCharacters[c] += 1;
                }
                else
                {
                    CountsInCharacters[c] = 1;
                }
            }

            foreach (var c in document)
            {
                if (!(CountsInCharacters.ContainsKey(c)) || CountsInCharacters[c] == 0)
                    return false;
                CountsInCharacters[c] -= 1;
            }

            return true;
        }
    }
}