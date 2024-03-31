namespace Min_Heap_Construction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> array = new List<int>() { 48, 12, 24, 7, 8, -5, 24, 391, 24, 56, 2, 6, 8, 41 };
            MinHeap minHeap = new MinHeap(array);
            minHeap.buildHeap(array);
            minHeap.Insert(76);
            minHeap.Peek();
            minHeap.Remove();
            minHeap.Peek();
            minHeap.Remove();
            minHeap.Peek();
            minHeap.Insert(87);
        }
        public class MinHeap
        {
            //Heap is a complete Binary tree
            //the last level may be partially filled but if so it should be from left to right
            //the root node is the smallest value in the heap
            //index 0 is the root node 
            //if current node is at position i
            //child one is i*2+1
            //child two is i*2+2
            //parent node of a node i is at (i-1)/2
            public List<int> heap = new List<int>();

            public MinHeap(List<int> array)
            {
                heap = buildHeap(array);
            }
            //O(n) time / O(1) space
            public List<int> buildHeap(List<int> array)
            {
                // Write your code here.
                int firstParentIndx = (array.Count - 2) / 2;
                for (int i = firstParentIndx; i >= 0; i--)
                {
                    siftDown(i, array.Count - 1, array);
                }
                return array;
            }
            //O(log(n)) time / O(1) space
            public void siftDown(int currentIdx, int endIdx, List<int> heap)
            {
                // Write your code here.
                int childOneIdx = currentIdx * 2 + 1;
                while (childOneIdx <= endIdx)
                {
                    int childTwoIdx;
                    if (currentIdx * 2 + 2 <= endIdx)
                        childTwoIdx = currentIdx * 2 + 2;
                    else
                        childTwoIdx = -1;
                    //determine which of the childs should be swapped
                    int idxToSwap;
                    if (childTwoIdx != -1 && heap[childTwoIdx] < heap[childOneIdx])
                        idxToSwap = childTwoIdx;
                    else
                        idxToSwap = childOneIdx;

                    if (heap[idxToSwap] < heap[currentIdx])
                    {
                        swap(currentIdx, idxToSwap, heap);
                        currentIdx = idxToSwap;
                        childOneIdx = currentIdx * 2 + 1;
                    }
                    else
                        return;
                }
            }
            //O(log(n)) time / O(1) space
            public void siftUp(int currentIdx, List<int> heap)
            {
                // Write your code here.
                int parentIndx = (currentIdx - 1) / 2;
                while (currentIdx > 0 && heap[currentIdx] < heap[parentIndx])
                {
                    swap(currentIdx, parentIndx, heap);
                    currentIdx = parentIndx;
                    parentIndx = (currentIdx - 1) / 2;
                }
            }

            public int Peek()
            {
                // Write your code here.
                return heap[0];
            }
            //removing the root node
            //swap the root with the last node and then remove the last 
            //and sift down 
            public int Remove()
            {
                // Write your code here.
                swap(0, heap.Count - 1, heap);
                int valueToRemove = heap[heap.Count - 1];
                heap.RemoveAt(heap.Count - 1);
                siftDown(0, heap.Count - 1, heap);
                return valueToRemove;
            }
            //we insert the value to be the last in the heap 
            //and sift up to put it in the correct position
            public void Insert(int value)
            {
                // Write your code here.
                heap.Add(value);
                siftUp(heap.Count - 1, heap);
            }

            public void swap(int i, int j, List<int> heap)
            {
                int temp = heap[j];
                heap[j] = heap[i];
                heap[i] = temp;
            }
        }
    }
}