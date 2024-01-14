namespace Smallest_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] result = SmallestDifference(new int[] { -2, 8, 5, 6, 3, 42, 44, 76 }, new int[] {  4, 2,22, 45, 33, 12 });
            foreach(int i in result)
            {
                Console.WriteLine(i);
            }
        }
        //O(nlog(n) + mlog(m)) time / O(1) Space 
        public static int[] SmallestDifference(int[] arrayOne, int[] arrayTwo)
        {
            // Write your code here.
            Array.Sort(arrayOne);
            Array.Sort(arrayTwo);

            int onePtr = 0;
            int twoPtr = 0;
            int minDiff = GetAbsDiff(arrayOne[0], arrayTwo[0]);
            int minOne = 0;
            int minTwo = 0;
            while (onePtr < arrayOne.Length && twoPtr < arrayTwo.Length)
            {
                if (GetAbsDiff(arrayOne[onePtr], arrayTwo[twoPtr]) == 0)
                {
                    return new int[] { arrayOne[onePtr], arrayTwo[twoPtr] };
                }
                else if (GetAbsDiff(arrayOne[onePtr], arrayTwo[twoPtr]) < minDiff)
                {
                    minDiff = GetAbsDiff(arrayOne[onePtr], arrayTwo[twoPtr]);
                    minOne = onePtr;
                    minTwo = twoPtr;
                    if (arrayOne[onePtr] < arrayTwo[twoPtr])
                        onePtr++;
                    else
                        twoPtr++;
                }
                else
                {
                    if (arrayOne[onePtr] < arrayTwo[twoPtr])
                        onePtr++;
                    else
                        twoPtr++;
                }
            }
            return new int[] { arrayOne[minOne], arrayTwo[minTwo] };
        }

        public static int GetAbsDiff(int a, int b)
        {
            if (a == b)
                return 0;
            if (a * b > 0)
                return Math.Abs(a - b);
            else
                return Math.Abs(a) + Math.Abs(b);
        }
    }
}