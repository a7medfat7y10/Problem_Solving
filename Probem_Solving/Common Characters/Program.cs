namespace Common_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            foreach ( var item in CommonCharacters(new string[] { "abc", "bcd", "cbaccb" }))
            {
                Console.WriteLine(item);
            }

        }
        //O(n^2) time / O(n) space
        public static string[] CommonCharacters(string[] strings)
        {
            // Write your code here.
            Dictionary<char, int> counts = new Dictionary<char, int>();
            for (int i = 0; i < strings.Length; i++)
            {
                HashSet<char> distinctchars = new HashSet<char>();
                for (int j = 0; j < strings[i].Length; j++)
                    distinctchars.Add(strings[i][j]);

                foreach (char c in distinctchars)
                {
                    if (counts.ContainsKey(c))
                        counts[c] += 1;
                    else
                        counts[c] = 1;
                }
            }

            List<string> commonChars = new List<string>();

            foreach (var key in counts.Keys)
            {
                if (counts[key] >= strings.Length)
                    commonChars.Add(key.ToString());
            }

            return commonChars.ToArray();
        }

        //Another solution
        public static string[] CommonCharactersV2(string[] strings)
        {
            // Write your code here.
            HashSet<char> commonChars = new HashSet<char>(strings[0]);
            foreach (string str in strings)
            {
                HashSet<char> strDistinctChars = new HashSet<char>(str);
                commonChars.IntersectWith(strDistinctChars);
            }

            string[] commonFinal = new string[commonChars.Count];
            int i = 0;
            foreach (char c in commonChars)
            {
                commonFinal[i] = c.ToString();
                i++;
            }
            return commonFinal;
        }

        //Another solution is to search for the shortest word so that the characters of this word
        //are the only characters that can be common and then check every character of this word
        //if it doesnot exist in any of the other words remove it from the common chars until you have
        //the final common characters
    }
}