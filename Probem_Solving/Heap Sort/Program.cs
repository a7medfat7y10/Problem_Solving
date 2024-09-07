namespace Heap_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] result = HeapSort(new int[] {3,5,3,2,1,6,5,9,4});
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }
        //O(nlog(n)) time / O(1) space
        public static int[] HeapSort(int[] array)
        {
            // Write your code here.
            buildMaxHeap(array);
            for (int i = array.Length - 1; i > 0; i--)
            {
                swap(0, i, array);
                siftDown(0, i - 1, array);
            }
            return array;
        }

        public static void buildMaxHeap(int[] array)
        {
            int firstParent = (array.Length - 2) / 2;
            for (int i = firstParent; i >= 0; i--)
            {
                siftDown(i, array.Length - 1, array);
            }
        }

        public static void siftDown(int current, int end, int[] heap)
        {
            int childOne = current * 2 + 1;
            while (childOne <= end)
            {
                int childTwo = current * 2 + 2;
                int idxToSwap;
                if (childTwo <= end && heap[childTwo] > heap[childOne])
                    idxToSwap = childTwo;
                else
                    idxToSwap = childOne;

                if (heap[idxToSwap] > heap[current])
                {
                    swap(current, idxToSwap, heap);
                    current = idxToSwap;
                    childOne = current * 2 + 1;
                }
                else
                    return;
            }
        }

        public static void swap(int i, int j, int[] array)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}