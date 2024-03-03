namespace Sunset_Views
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var i in SunsetViews(new int[] { 1, 4, 5, 3, 2, 3, 5, 6, 2 }, "EAST"))
            {
                Console.WriteLine(i);
            }
        }
        //O(n) time / O(n) space
        public static List<int> SunsetViews(int[] buildings, string direction)
        {
            // Write your code here.
            List<int> result = new List<int>();
            int start = buildings.Length - 1;
            int step = -1;
            if (direction == "WEST")
            {
                start = 0;
                step = 1;
            }
            int i = start;
            int MaxHeight = 0;
            while (i >= 0 && i < buildings.Length)
            {
                if (buildings[i] > MaxHeight)
                {
                    result.Add(i);
                    MaxHeight = buildings[i];
                }
                i += step;
            }

            if (direction == "EAST")
                result.Reverse();
            return result;
        }
    }
}