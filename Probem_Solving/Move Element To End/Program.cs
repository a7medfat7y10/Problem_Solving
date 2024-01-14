namespace Move_Element_To_End
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> result = MoveElementToEnd(new List<int>() { 2, 4, 5, 3, 4, 4, 2, 31, 3, 2 }, 4);
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }
        //O(n) time / O(1) space
        public static List<int> MoveElementToEnd(List<int> array, int toMove)
        {
            // Write your code here.
            int left = 0;
            int right = array.Count - 1;

            while (left < right)
            {
                if (array[right] == toMove)
                {
                    right--;
                    continue;
                }
                if (array[left] == toMove)
                {
                    int temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;
                }
                left++;
            }
            return array;
        }
    }
}