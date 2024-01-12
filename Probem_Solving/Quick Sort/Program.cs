namespace Quick_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = QuickSort(new int[] { 6, 7, 5, 3, 5, 7, 8, 2 });
            foreach (int i in arr)
                Console.WriteLine(i);
        }
        //O(nlog(n)) time / O(log(n)) space
        public static int[] QuickSort(int[] arr)
        {
            QuickSort(arr, 0, arr.Length - 1);
            return arr;
        }
        public static int[] QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex;

                int pivot = arr[high];
                int i = low - 1;

                for (int j = low; j < high; j++)
                {
                    //seperate the lower elements to the left of the pivot
                    if (arr[j] < pivot)
                    {
                        i++;

                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
                //take the pivot from the high position to the position of i+1 to be in the middle of the lower and higher elements
                int temp1 = arr[i + 1];
                arr[i + 1] = arr[high];
                arr[high] = temp1;

                //return the pivot index
                partitionIndex = i + 1;

                QuickSort(arr, low, partitionIndex - 1);
                QuickSort(arr, partitionIndex + 1, high);
            }
            return arr;
        }
    }
}