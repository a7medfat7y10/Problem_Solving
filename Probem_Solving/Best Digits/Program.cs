using System.Text;

namespace Best_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BestDigits("682345" , 2));
        }
        //O(n) time / O(n) space
        public static string BestDigits(string number, int numDigits)
        {
            // Write your code here.
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < number.Length; i++)
            {
                char character = number[i];
                while (stack.Count > 0 && numDigits > 0 && character > stack.Peek())
                {
                    numDigits--;
                    stack.Pop();
                }
                stack.Push(character);
            }
            while (numDigits > 0)
            {
                numDigits--;
                stack.Pop();
            }
            StringBuilder result = new StringBuilder();
            while (stack.Count > 0)
            {
                result.Append(stack.Pop());
            }
            var charArray = result.ToString().ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}