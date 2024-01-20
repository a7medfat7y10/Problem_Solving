namespace Array_Of_Products
{
    internal class Program
    {
        //O(n) time / O(n) space
        static void Main(string[] args)
        {
            int[] result = ArrayOfProducts(new int[] { 3, 4, 5, 3, 4, 2 });
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }
        public static int[] ArrayOfProducts(int[] array)
        {
            // Write your code here.
            int[] prod = new int[array.Length];
            int i = 0;
            int leftProd = 1;
            int rightProd = 1;
            int left = 0;
            int right = array.Length - 1;
            while (i < array.Length)
            {
                if (left < i)
                {
                    leftProd *= array[left];
                    left++;
                }
                if (right > i)
                {
                    rightProd *= array[right];
                    right--;
                }
                if (left == i && right == i)
                {
                    prod[i] = leftProd * rightProd;
                    i++;
                    leftProd = 1;
                    rightProd = 1;
                    left = 0;
                    right = array.Length - 1;
                }
            }
            return prod;
        }
    }
}