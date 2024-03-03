namespace Balanced_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BalancedBrackets("(){[]}"));
        }
        //O(n) time / O(n) space
        public static bool BalancedBrackets(string str)
        {
            // Write your code here.
            string openingBrackets = "([{";
            string closingBrackets = ")]}";
            Dictionary<char, char> matchingBrackets = new Dictionary<char, char>();
            matchingBrackets.Add(')', '(');
            matchingBrackets.Add(']', '[');
            matchingBrackets.Add('}', '{');

            List<char> stack = new List<char>();

            for (int i = 0; i < str.Length; i++)
            {
                if (openingBrackets.IndexOf(str[i]) != -1)
                {
                    stack.Add(str[i]);
                }
                else if (closingBrackets.IndexOf(str[i]) != -1)
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    if (stack[stack.Count - 1] == matchingBrackets[str[i]])
                    {
                        stack.RemoveAt(stack.Count - 1);
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
    }
}