namespace Majority_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MajorityElement(new int[] { 1,3,3,2,2,2,5 }));
        }
        //O(n) time / O(1) space
        public static int MajorityElement(int[] array)
        {
            // Write your code here.
            int count = 0;
            int majorElement = 0;
            //if count = 0 this means that there is no major element in the provious part of the array
            foreach (int value in array)
            {
                if (count == 0)
                    majorElement = value;
                if (value == majorElement)
                    count++;
                else
                    count--;
            }
            return majorElement;
        }
    }
}