namespace Stable_Internships
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] interns =
            {
                new int[] {0,1,2},
                new int[] {1,0,2},
                new int[] {1,2,0}
            };
            int[][] teams =
            {
                new int[] {2,1,0},
                new int[] {1,2,0},
                new int[] {0,2,1}
            };
            int[][] result = StableInternships(interns, teams);
            foreach (int[] res in result) { 
                foreach (int i in res)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("**");
            }
        }
        //O(n^2) time / O(n^2) space
        public static int[][] StableInternships(int[][] interns, int[][] teams)
        {
            // Write your code here.
            //a dictionary to put the result {team:intern, team:intern}
            Dictionary<int, int> result = new Dictionary<int, int>();
            //stack to have the free interns and populate it with indexes
            Stack<int> freeInterns = new Stack<int>();
            for (int i = 0; i < interns.Length; i++)
            {
                freeInterns.Push(i);
            }
            //array to have the current choices of each intern
            int[] currentChoices = new int[interns.Length];
            //this list of dictionaries to have a rank table for each intern to t he team
            List<Dictionary<int, int>> teamRanks = new List<Dictionary<int, int>>();
            foreach (var team in teams)
            {
                Dictionary<int, int> rank = new Dictionary<int, int>();
                for (int i = 0; i < team.Length; i++)
                {
                    rank[team[i]] = i;
                }
                teamRanks.Add(rank);
            }

            while (freeInterns.Count != 0)
            {
                int intern = freeInterns.Pop();
                int[] internChoices = interns[intern];
                int teamPreference = internChoices[currentChoices[intern]];
                currentChoices[intern]++;
                if (!result.ContainsKey(teamPreference))
                {
                    result[teamPreference] = intern;
                    continue;
                }
                int previousIntern = result[teamPreference];
                int previousInternRank = teamRanks[teamPreference][previousIntern];
                int currentInternRank = teamRanks[teamPreference][intern];
                if (currentInternRank < previousInternRank)
                {
                    freeInterns.Push(previousIntern);
                    result[teamPreference] = intern;
                }
                else
                {
                    freeInterns.Push(intern);
                }
            }

            int[][] matches = new int[interns.Length][];
            int indx = 0;
            foreach (var choice in result)
            {
                matches[indx] = new int[] { choice.Value, choice.Key };
                indx++;
            }
            return matches;
        }
    }
}