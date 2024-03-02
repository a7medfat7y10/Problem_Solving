namespace Blackjack_Probability
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BlackjackProbability(21, 15));
        }
        //O(t-s) time / O(t-s) space where t is target ,  s is startingHand
        public static float BlackjackProbability(int target, int startingHand)
        {
            // Write your code here.
            Dictionary<int, float> probabilities = new Dictionary<int, float>();
            return (float)Math.Round(calculateProbability(target, startingHand, probabilities) * 1000f) / 1000f;
        }
        public static float calculateProbability(int target, int currentHand, Dictionary<int, float> probabilities)
        {
            if (probabilities.ContainsKey(currentHand))
                return probabilities[currentHand];
            if (currentHand > target)
                return 1;
            if (currentHand + 4 >= target)
                return 0;

            float total = 0;
            for (int drawn = 1; drawn <= 10; drawn++)
            {
                total += (float).1 * calculateProbability(target, currentHand + drawn, probabilities);
            }
            probabilities[currentHand] = total;
            return total;
        }
    }
}