namespace Next_Greater_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (int i in NextGreaterElementV2(new int[] {1,-2,3,2,1,6,7}))
            {
                Console.WriteLine(i);
            }
        }
        //O(n^2) time / O(n) space
        public static int[] NextGreaterElement(int[] array)
        {
            // Write your code here.
            int[] result = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = -1;
                for (int j = i + 1; j < array.Length + i + 1; j++)
                {
                    if (array[j % array.Length] > array[i])
                    {
                        result[i] = array[j % array.Length];
                        break;
                    }
                }
            }
            return result;
        }
        //Another solution using Stack
        //O(n) time / O(n) space
        public static int[] NextGreaterElementV2(int[] array)
        {
            // Write your code here.
            int[] result = new int[array.Length];
            Array.Fill(result, -1);
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < array.Length * 2; i++)
            {
                int circularIndx = i % array.Length;
                while (stack.Count > 0 && array[stack.Peek()] < array[circularIndx])
                {
                    int top = stack.Pop();
                    result[top] = array[circularIndx];
                }
                stack.Push(circularIndx);
            }
            return result;
        }
    }
}