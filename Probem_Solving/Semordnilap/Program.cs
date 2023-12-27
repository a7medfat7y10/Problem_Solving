namespace Semordnilap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> list = Semordnilap(new string[] { "abc", "ahmed", "test", "demha", "cba" });
            foreach (var item in list)
            {
                foreach (var item2 in item)
                {
                    Console.WriteLine(item2);
                }
                Console.WriteLine("--------");
            }
            Console.WriteLine();
        }

        //O(n^2) time , O(n^2) space
        public static List<List<string>> Semordnilap(string[] words)
        {
            // Write your code here.
            HashSet<string> wordSet = new HashSet<string>(words);
            List<List<string>> result = new List<List<string>>();

            for (int i = 0; i < words.Length; i++)
            {
                string str = words[i];

                char[] stringArray = str.ToCharArray();
                Array.Reverse(stringArray);
                string reversedStr = new string(stringArray);

                wordSet.Remove(str);
                if (wordSet.Contains(reversedStr))
                {
                    result.Add(new List<string>() { str, reversedStr });
                    wordSet.Remove(reversedStr);
                }
            }
            return result;
        }
    }
}