namespace Permutations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach(var lst in GetPermutations(new List<int> { 1, 2, 3 }))
            {
                foreach(int num in lst)
                {
                    Console.Write(num);
                }
                Console.WriteLine();
            }
        }
        //O(n*n!) time / O(n*n!) space
        public static List<List<int>> GetPermutations(List<int> array)
        {
            // Write your code here.
            List<List<int>> permutations = new List<List<int>>();
            GetPermutations(array, new List<int>(), permutations);
            return permutations;
        }
        public static void GetPermutations(List<int> array, List<int> currentPermutation, List<List<int>> permutations)
        {
            if (array.Count == 0 && currentPermutation.Count > 0)
            {
                permutations.Add(currentPermutation);
            }
            else
            {
                for (int i = 0; i < array.Count; i++)
                {
                    List<int> newArray = new List<int>(array);
                    newArray.RemoveAt(i);
                    List<int> newPermutation = new List<int>(currentPermutation);
                    newPermutation.Add(array[i]);
                    GetPermutations(newArray, newPermutation, permutations);
                }
            }
        }
    }
}