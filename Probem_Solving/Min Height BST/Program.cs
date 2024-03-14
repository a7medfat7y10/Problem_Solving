namespace Min_Height_BST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Min Height BST");
        }
        //O(n) time / O(n) space
        public static BST MinHeightBst(List<int> array)
        {
            // Write your code here.
            return MinHeightBst(array, 0, array.Count - 1);
        }

        public static BST MinHeightBst(List<int> array, int start, int end)
        {
            if (end < start)
                return null;
            int mid = (start + end) / 2;
            BST bst = new BST(array[mid]);
            bst.left = MinHeightBst(array, start, mid - 1);
            bst.right = MinHeightBst(array, mid + 1, end);
            return bst;
        }

        public class BST
        {
            public int value;
            public BST left;
            public BST right;

            public BST(int value)
            {
                this.value = value;
                left = null;
                right = null;
            }

            public void insert(int value)
            {
                if (value < this.value)
                {
                    if (left == null)
                    {
                        left = new BST(value);
                    }
                    else
                    {
                        left.insert(value);
                    }
                }
                else
                {
                    if (right == null)
                    {
                        right = new BST(value);
                    }
                    else
                    {
                        right.insert(value);
                    }
                }
            }
        }
    }
}