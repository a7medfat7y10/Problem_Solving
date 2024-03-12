namespace Single_Cycle_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HasSingleCycle(new int[] {2,3,1,-4,-4,2}));
        }
        //O(n) time / O(1) space
        public static bool HasSingleCycle(int[] array)
        {
            // Write your code here.
            int numOfVisits = 0;
            int i = 0;
            while (numOfVisits < array.Length)
            {
                if (numOfVisits > 0 && i == 0)
                    return false;
                i = (i + array[i]) % array.Length;
                if (i < 0)
                    i += array.Length;

                numOfVisits++;
            }
            return i == 0;
        }
    }
}