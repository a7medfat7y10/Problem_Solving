namespace Levenshtein_Distance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LevenshteinDistance("abd", "yabc"));
        }
        //O(nm) time / O(nm) space
        public static int LevenshteinDistance(string str1, string str2)
        {
            // Write your code here.
            int[,] editsTable = new int[str2.Length + 1, str1.Length + 1];
            for (int i = 0; i < str2.Length + 1; i++)
            {
                for (int j = 0; j < str1.Length + 1; j++)
                {
                    editsTable[i, j] = j;
                }
                //the first row which is the empty string edits to turn to the first string 
                editsTable[i, 0] = i;
            }
            for (int i = 1; i < str2.Length + 1; i++)
            {
                for (int j = 1; j < str1.Length + 1; j++)
                {
                    if (str2[i - 1] == str1[j - 1])
                    {
                        editsTable[i, j] = editsTable[i - 1, j - 1];
                    }
                    else
                    {
                        editsTable[i, j] = 1 + Math.Min(editsTable[i - 1, j - 1],
                                                        Math.Min(editsTable[i - 1, j], editsTable[i, j - 1]));
                    }
                }
            }
            return editsTable[str2.Length, str1.Length];
        }
    }
}