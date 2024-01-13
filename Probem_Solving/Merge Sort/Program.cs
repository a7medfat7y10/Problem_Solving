namespace Merge_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = MergeSortV2(new int[] { 6, 7, 5, 3, 5, 7, 8, 2 });
            foreach (int i in arr)
                Console.WriteLine(i);
            
        }
        //O(nlog(n)) time /O(nlog(n)) space
        public static int[] MergeSort(int[] array)
        {
            // Write your code here.
            MergeSort(array, 0, array.Length - 1);
            return array;
        }
        public static int[] MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;

                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);

                Merge(arr, left, mid, right);
            }
            return arr;
        }

        private static void Merge(int[] arr, int left, int mid, int right)
        {
            int left_length = mid - left + 1;
            int right_length = right - mid;

            int[] Left_Array = new int[left_length];
            int[] Right_Array = new int[right_length];

            Array.Copy(arr, left, Left_Array, 0, left_length);
            Array.Copy(arr, mid + 1, Right_Array, 0, right_length);

            int i = 0, j = 0;
            int k = left;

            while (i < left_length && j < right_length)
            {
                if (Left_Array[i] <= Right_Array[j])
                {
                    arr[k] = Left_Array[i];
                    i++;
                }
                else
                {
                    arr[k] = Right_Array[j];
                    j++;
                }
                k++;
            }

            while (i < left_length)
            {
                arr[k] = Left_Array[i];
                i++;
                k++;
            }

            while (j < right_length)
            {
                arr[k] = Right_Array[j];
                j++;
                k++;
            }
        }



        //Another optimized solution 
        //O(nlog(n)) time /O(n) space
        //using only another copy of the array(auxiliary array)
        public static int[] MergeSortV2(int[] array)
        {
            // Write your code here.
            if (array.Length <= 0)
                return array;
            int[] auxiliaryArray = (int[])array.Clone();

            MergeSort(array, 0, array.Length - 1, auxiliaryArray);
            return array;
        }
        public static int[] MergeSort(int[] arr, int left, int right, int[] auxiliaryArr)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;

                MergeSort(auxiliaryArr, left, mid,arr );
                MergeSort(auxiliaryArr, mid + 1, right, arr);

                Merge(arr, left, mid, right, auxiliaryArr);
            }
            return arr;
        }

        private static void Merge(int[] arr, int left, int mid, int right, int[] auxiliaryArr)
        {
            int i = left, j = mid + 1;
            int k =left ;

            while (i <= mid && j <= right)
            {
                if (auxiliaryArr[i] <= auxiliaryArr[j])
                {
                    arr[k] = auxiliaryArr[i];
                    i++;
                }
                else
                {
                    arr[k] = auxiliaryArr[j];
                    j++;
                }
                k++;
            }

            while (i <= mid)
            {
                arr[k] = auxiliaryArr[i];
                i++;
                k++;
            }

            while (j <= right)
            {
                arr[k] = auxiliaryArr[j];
                j++;
                k++;
            }
        }
    }
}