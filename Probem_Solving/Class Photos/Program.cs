namespace Class_Photos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ClassPhotos(new List<int>() { 3,4,2,5,6} , new List<int>() { 6, 2, 1, 8, 5 }));
        }
        //O(nlog(n)) time / O(1) space
        public static bool ClassPhotos(List<int> redShirtHeights, List<int> blueShirtHeights)
        {
            redShirtHeights.Sort();
            redShirtHeights.Reverse();
            blueShirtHeights.Sort();
            blueShirtHeights.Reverse();

            int diff = redShirtHeights[0] - blueShirtHeights[0];
            if (diff == 0)
                return false;

            for (int i = 0; i < blueShirtHeights.Count; i++)
            {
                if (diff > 0 && redShirtHeights[i] <= blueShirtHeights[i])
                    return false;
                else if (diff < 0 && redShirtHeights[i] >= blueShirtHeights[i])
                    return false;
            }
            return true;
        }
    }
}