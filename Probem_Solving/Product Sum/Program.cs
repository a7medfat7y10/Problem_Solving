namespace Product_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ProductSum(new List<object>() { 1, 3, 4, new List<object>() { 2, -3 }, 3 }));
        }
        //O(n) time / O(n) space
        public static int ProductSum(List<object> array, int depth = 1)
        {
            // Write your code here.
            int sum = 0;
            for (int i = 0; i < array.Count; i++)
            {
                if (array[i] is IList<object>)
                {
                    sum += (int)ProductSum((List<object>)array[i], depth + 1);
                }
                else
                {
                    sum += (int)array[i];
                }
            }

            return sum * depth;
        }
    }
}