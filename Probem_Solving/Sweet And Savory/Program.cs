namespace Sweet_And_Savory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] result = SweetAndSavory(new int[] {1,4,3,55,24, -2,-8,-16} , 9);
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }
        //O(nlog(n)) time / O(1) space
        public static int[] SweetAndSavory(int[] dishes, int target)
        {
            // Write your code here.
            int left = 0;
            int right = dishes.Length - 1;
            Array.Sort(dishes);
            int currentFlavor = 0;
            int bestDiff = int.MaxValue;
            int[] bestFlavor = new int[2];
            while (left < right && dishes[left] < 0 && dishes[right] > 0)
            {
                currentFlavor = dishes[left] + dishes[right];
                if (currentFlavor <= target)
                {
                    if (target - currentFlavor <= bestDiff)
                    {
                        bestDiff = target - currentFlavor;
                        bestFlavor[0] = dishes[left];
                        bestFlavor[1] = dishes[right];
                    }
                    left++;
                }
                else
                    right--;
            }
            return bestFlavor;
        }
    }
}