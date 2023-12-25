namespace Run_Length_Encoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RunLengthEncoding("AAAAAAAAAAbbbbbbbbc"));
        }
        //O(n) Time / O(n) Space
        public static string RunLengthEncoding(string str)
        {
            // Write your code here.
            int count = 1;
            string output = "";
            string result;
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == str[i - 1] && count <9)
                {
                    count++;
                }
                else
                {
                    result = count.ToString() + str[i - 1];
                    output += result;
                    count = 1;
                }
            }
            result = count.ToString() + str[str.Length -1];
            output += result;

            return output;
        }
    }
}