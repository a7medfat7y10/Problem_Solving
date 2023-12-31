namespace Bubble_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BubbleSort(new int[] {3,5,6,4,7,2}));
        }
        public static int[] BubbleSort(int[] array)
        {
            // Write your code here.
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }
    }
}