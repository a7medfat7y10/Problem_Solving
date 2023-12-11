namespace Sorted_Squared_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach(int item in SortedSquaredArray(new int[] { -11, -2, 3, 4, 5 }))
            {
                Console.WriteLine(item);
            }
        }

        // O(nlog(n)) time / O(n) space
        public int[] SortedSquaredArrayV1(int[] array)
        {
            // Write your code here.
            int[] newarray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                newarray[i] = array[i] * array[i];
            }

            Array.Sort(newarray);
            return newarray;
        }

        //Optimal Solution O(n) time / O(n) space
        public static int[] SortedSquaredArray(int[] array)
        {
            // Write your code here.
            int[] newarray = new int[array.Length];
            int left = 0;
            int right = array.Length - 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[left]) < Math.Abs(array[right]))
                {
                    newarray[array.Length - i - 1] = array[right] * array[right];
                    right--;
                }
                else
                {
                    newarray[array.Length - i - 1] = array[left] * array[left];
                    left++;
                }
            }
            return newarray;
        }
    }
}