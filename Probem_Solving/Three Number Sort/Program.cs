namespace Three_Number_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] result = ThreeNumberSort(new int[] { 1, 1, -1, 0, 1, -1, -1, 1, 0, 0, 1 }, new int[] { 0, 1, -1 });
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }
        //O(n) time / O(1) space
        public static int[] ThreeNumberSort(int[] array, int[] order)
        {
            // Write your code here.
            int i = 0;

            //points to the middle element
            int left = 0;
            //points to the third element
            int right = array.Length - 1;

            while (i <= right)
            {
                //if the element is the first element
                if (array[i] == order[0])
                {
                    //swap the element at i and the element where the middle pointer at
                    //then increase the two pointers by 1
                    int temp = array[i];
                    array[i] = array[left];
                    array[left] = temp;
                    i++;
                    left++;
                }
                //if it is the last element
                else if (array[i] == order[2])
                {
                    //swap the element at i and the element where the last pointer at
                    //then decrease the pointer to the last element by 1
                    int temp = array[right];
                    array[right] = array[i];
                    array[i] = temp;
                    right--;
                }
                //if it is the middle element increase i and leave the middle pointer where it is.
                else
                {
                    i++;
                }
            }
            return array;
        }
    }
}