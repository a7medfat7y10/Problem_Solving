namespace Sort_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach(var num in SortStack(new List<int> { 1, -2, 5, 3, -5 }))
            {
                Console.WriteLine(num);
            }
            
        }
        //O(n^2) time / O(n) space
        public static List<int> SortStack(List<int> stack)
        {
            // Write your code here.
            if (stack.Count == 0)
                return stack;
            int top = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            SortStack(stack);
            insertInSortedOrder(stack, top);

            return stack;
        }
        public static void insertInSortedOrder(List<int> stack, int num)
        {
            // Write your code here.
            if (stack.Count == 0 || stack[stack.Count - 1] <= num)
            {
                stack.Add(num);
                return;
            }
            int top = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            insertInSortedOrder(stack, num);
            stack.Add(top);
        }
    }
}