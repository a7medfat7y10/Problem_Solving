namespace Tournament_Winner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> round1= new List<string>() { "HTML","C#"};
            List<string> round2= new List<string>() { "C#","Python"};
            List<string> round3= new List<string>() { "Python","HTML"};
            List<List<string>> competitions = new List<List<string>>() { round1, round2, round3};

            List<int> results = new List<int>() { 0,0,1};
            Console.WriteLine(TournamentWinner(competitions, results));
        }

        //O(n) Time , O(n) Space
        public static string TournamentWinner(List<List<string>> competitions, List<int> results)
        {
            // Write your code here.
            Dictionary<string, int> scoreBoard = new Dictionary<string, int>();
            string winner = "";
            scoreBoard[winner] = 0;
            for (int i = 0; i < competitions.Count; i++)
            {
                if (results[i] == 0)
                {
                    if (scoreBoard.ContainsKey(competitions[i][1]))
                    {
                        scoreBoard[competitions[i][1]] += 3;
                    }
                    else
                    {
                        scoreBoard[competitions[i][1]] = 3;
                    }
                    if (scoreBoard[winner] < scoreBoard[competitions[i][1]])
                    {
                        winner = competitions[i][1];
                    }
                }
                else
                {
                    if (scoreBoard.ContainsKey(competitions[i][0]))
                    {
                        scoreBoard[competitions[i][0]] += 3;
                    }
                    else
                    {
                        scoreBoard[competitions[i][0]] = 3;
                    }
                    if (scoreBoard[winner] < scoreBoard[competitions[i][0]])
                    {
                        winner = competitions[i][0];
                    }
                }
            }
            return winner;
        }
    }
}