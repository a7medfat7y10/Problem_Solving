namespace Selection_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SelectionSort(new int[] {3,5,4,6,2,1}));
        }
        public static int[] SelectionSort(int[] array)
        {
            // Write your code here.
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                        minIndex = j;
                }

                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
            return array;
        }
    }
}