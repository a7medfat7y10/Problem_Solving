namespace Insertion_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(InsertionSort(new int[] {1,5,6,3,4,2,9}));
        }
        public static int[] InsertionSort(int[] array)
        {
            // Write your code here.
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = 0;

                for (j = i - 1; j >= 0; --j)
                {
                    if ((array[j] > key))
                    {
                        array[j + 1] = array[j];
                    }
                    else
                    {
                        break;
                    }
                }
                array[j + 1] = key;
            }
            return array;
        }
    }
}