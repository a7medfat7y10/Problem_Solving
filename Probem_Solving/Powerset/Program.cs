namespace Powerset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var lst in Powerset(new List<int> { 1, 2, 3 }))
            {
                foreach (int num in lst)
                {
                    Console.Write(num);
                }
                Console.WriteLine();
            }
        }
        //Iterative Solution
        //O(n*2^n) time / O(n*2^n) space
        public static List<List<int>> Powerset(List<int> array)
        {
            // Write your code here
            List<List<int>> subsets = new List<List<int>>();
            subsets.Add(new List<int>());
            for (int i = 0; i < array.Count; i++)
            {
                int subsetsLength = subsets.Count;
                for (int j = 0; j < subsetsLength; j++)
                {
                    List<int> currentSubset = new List<int>(subsets[j]);
                    currentSubset.Add(array[i]);
                    subsets.Add(currentSubset);
                }
            }
            return subsets;
        }
        //Recursive Solution
        //O(n*2^n) time / O(n*2^n) space
        public static List<List<int>> PowersetV2(List<int> array)
        {
            // Write your code here.
            return Powerset(array, array.Count - 1);
        }
        public static List<List<int>> Powerset(List<int> array, int indx)
        {
            if (indx < 0)
            {
                List<List<int>> empty = new List<List<int>>();
                empty.Add(new List<int>());
                return empty;
            }
            int ele = array[indx];
            List<List<int>> subsets = Powerset(array, indx - 1);
            int subsetsLength = subsets.Count;
            for (int i = 0; i < subsetsLength; i++)
            {
                List<int> currentSubset = new List<int>(subsets[i]);
                currentSubset.Add(ele);
                subsets.Add(currentSubset);
            }
            return subsets;
        }
    }
}