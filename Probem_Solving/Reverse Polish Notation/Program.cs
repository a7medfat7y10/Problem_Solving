namespace Reverse_Polish_Notation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReversePolishNotation(new string[] {"10" , "3" , "-" , "7" , "/"}));
        }
        //O(n) time / O(n) space
        public static int ReversePolishNotation(string[] tokens)
        {
            // Write your code here.
            Stack<int> stack = new Stack<int>();
            foreach (string token in tokens)
            {
                if (token == "+")
                    stack.Push(stack.Pop() + stack.Pop());
                else if (token == "-")
                    stack.Push(-1 * (stack.Pop() - stack.Pop()));
                else if (token == "*")
                    stack.Push(stack.Pop() * stack.Pop());
                else if (token == "/") {
                    int firstNum = stack.Pop();
                    stack.Push(stack.Pop() / firstNum);
                }
                else
                    stack.Push(int.Parse(token));
            }
            return stack.Pop();
        }
    }
}