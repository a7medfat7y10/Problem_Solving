namespace First_Duplicate_Value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstDuplicateValue(new int[] {2,4,3,2,6,3}));
        }
        //O(n) time / O(n) space
        public static int FirstDuplicateValue(int[] array)
        {
            // Write your code here.
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (dict.ContainsKey(array[i]))
                {
                    return array[i];
                }
                dict.Add(array[i], 1);
            }
            return -1;
        }
        //Another Solution
        //O(n) time / O(1) Space
        public int FirstDuplicateValueV2(int[] array)
        {
            // Write your code here.
            for (int i = 0; i < array.Length; i++)
            {
                int num = Math.Abs(array[i]);
                int indx = num - 1;
                if (array[indx] < 0)
                    return num;
                array[indx] = array[indx] * -1;
            }
            return -1;
        }
    }
}