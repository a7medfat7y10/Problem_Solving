namespace Valid_Starting_City
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValidStartingCity(new int[] {5,25,15,10,15}, new int[] {1,2,1,0,3}, 10));
        }
        //O(n) time / O(1) space
        public static int ValidStartingCity(int[] distances, int[] fuel, int mpg)
        {
            // Write your code here.
            //the starting city should be the city with the most miles remaining
            int milesInTank = 0;
            //start from city 0
            int startingCityIdx = 0;
            int milesRemainingAtStartingCity = 0;
            for (int i = 1; i < distances.Length; i++)
            {
                milesInTank += fuel[i - 1] * mpg - distances[i - 1];
                //if the fuel is not enough
                if (milesInTank < milesRemainingAtStartingCity)
                {
                    milesRemainingAtStartingCity = milesInTank;
                    startingCityIdx = i;
                }
            }
            return startingCityIdx;
        }
    }
}