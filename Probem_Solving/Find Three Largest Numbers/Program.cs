namespace Find_Three_Largest_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (int num in FindThreeLargestNumbers(new int[] { 3, 4, 2, 7, 566, 42, 2, 1, 77 }))
            {
                Console.WriteLine(num);
            }
        }
        public static int[] FindThreeLargestNumbers(int[] array)
        {
            // Write your code here.
            int[] result = new int[3] { int.MinValue, int.MinValue, int.MinValue };
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > result[2])
                {
                    result[0] = array[i];
                    swap(0, 2, result);
                    swap(0, 1, result);
                }
                else if (array[i] > result[1])
                {
                    result[0] = array[i];
                    swap(0, 1, result);
                }
                else if (array[i] > result[0])
                {
                    result[0] = array[i];
                }
            }
            return result;
        }
        public static int[] swap(int indx1, int indx2, int[] result)
        {
            int temp = result[indx1];
            result[indx1] = result[indx2];
            result[indx2] = temp;

            return result;
        }
    }
}