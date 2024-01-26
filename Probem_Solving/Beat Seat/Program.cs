namespace Beat_Seat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BestSeat(new int[] {1,0,0,0,1,1,1,0}));
        }
        //O(n) time / O(1) space
        public static int BestSeat(int[] seats)
        {
            // Write your code here.
            int firstFromRightEmptySeat = -1;
            int longestEmptySeats = 0;
            int currentEmptySeats = 0;
            int beatSeat = -1;
            for (int i = 0; i < seats.Length; i++)
            {
                if (seats[i] == 0)
                {
                    currentEmptySeats++;
                    if (currentEmptySeats > longestEmptySeats)
                    {
                        longestEmptySeats = currentEmptySeats;
                        firstFromRightEmptySeat = i;
                    }
                }
                else
                {
                    currentEmptySeats = 0;
                }
            }
            if (firstFromRightEmptySeat > 0)
            {
                beatSeat = firstFromRightEmptySeat - (longestEmptySeats / 2);
            }

            return beatSeat;
        }
    }
}