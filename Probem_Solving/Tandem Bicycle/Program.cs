namespace Tandem_Bicycle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] red = new int[] { 2, 3, 1, 7, 5 }; 
            int[] blue = new int[] { 7, 2, 3, 9, 3 };
            Console.WriteLine(TandemBicycle(red, blue, true));
        }
        //O(nlog(n)) time / O(1) space
        public static int TandemBicycle(int[] redShirtSpeeds, int[] blueShirtSpeeds, bool fastest)
        {
            Array.Sort(redShirtSpeeds);
            Array.Sort(blueShirtSpeeds);

            if (fastest == true)
                Array.Reverse(blueShirtSpeeds);

            int totalSpeed = 0;
            for (int i = 0; i < blueShirtSpeeds.Length; i++)
            {
                if (redShirtSpeeds[i] >= blueShirtSpeeds[i])
                    totalSpeed += redShirtSpeeds[i];
                else if (redShirtSpeeds[i] < blueShirtSpeeds[i])
                    totalSpeed += blueShirtSpeeds[i];
            }

            return totalSpeed;
        }
    }
}