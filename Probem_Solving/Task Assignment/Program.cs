namespace Task_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> result = TaskAssignment(3, new List<int>() { 1, 3, 5, 3, 1, 4 });
            foreach(var item in result)
            {
                foreach(var i in item )
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("***********");
            }
        }
        //O(nlog(n)) time / O(n) space
        public static List<List<int>> TaskAssignment(int k, List<int> tasks)
        {
            // Write your code here.
            List<List<int>> result = new List<List<int>>();
            List<int> tasksSorted = new List<int>(tasks);
            tasksSorted.Sort();

            int left = 0;
            int right = tasks.Count - 1;
            while (left < right)
            {
                int leftIndx = tasks.FindIndex(t => t == tasksSorted[left]);
                int rightIndx = tasks.FindIndex(t => t == tasksSorted[right]);
                tasks[leftIndx] = -1;
                tasks[rightIndx] = -1;
                result.Add(new List<int>() { leftIndx, rightIndx });
                left++;
                right--;
            }
            return result;
        }
    }
}