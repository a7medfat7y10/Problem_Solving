namespace Radix_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = RadixSort(new List<int> { 3, 2, 1, 5, 6, 4, 2, 9, 6, 3 });
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
        public static List<int> RadixSort(List<int> array)
        {
            // Write your code here.
            if (array.Count <= 1)
                return array;
            //get the max number to apply sorting on every digit
            int maxNumber = array.Max();
            int digit = 0;
            while ((maxNumber / Math.Pow(10, digit)) > 0)
            {
                countingSort(array, digit);
                digit++;
            }


            return array;
        }

        public static void countingSort(List<int> array, int digit)
        {
            int[] sortedArray = new int[array.Count];
            int[] countingArray = new int[10];

            int digitColumn = (int)Math.Pow(10, digit);
            //loop throught all the numbers to count each digit
            foreach (var num in array)
            {
                int countIndex = (num / digitColumn) % 10; // this will give me the digit
                                                           //increase the count of this digit index in countingArray
                countingArray[countIndex] += 1;
            }

            //calculate the cummulative counts for each digit in the countingArray
            for (int i = 1; i < 10; i++)
            {
                countingArray[i] += countingArray[i - 1];
            }

            //then loop througth all the numbers to use the calculated cummulative counts and 
            //put them in the correct order in sorted array
            for (int i = array.Count - 1; i >= 0; i--)
            {
                int num = array[i];
                int countIndex = (num / digitColumn) % 10;
                countingArray[countIndex] -= 1;
                int sortedIndex = countingArray[countIndex];
                sortedArray[sortedIndex] = array[i];
            }

            //copy the sorted Array into the original Array
            for (int i = 0; i < array.Count; i++)
            {
                array[i] = sortedArray[i];
            }
        }
    }
}