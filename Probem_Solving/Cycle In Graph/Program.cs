namespace Cycle_In_Graph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CycleInGraph(new int[][] { 
                new int[] {1,3},
                new int[] {2,3,4},
                new int[] {0},
                new int[] {},
                new int[] {2,5},
                new int[] {}
            }));
        }
        //O(v+e) time / O(v) space
        public static bool CycleInGraph(int[][] edges)
        {
            // Write your code here.
            bool[] visited = new bool[edges.Length];
            bool[] currentlyInStack = new bool[edges.Length];
            Array.Fill(visited, false);
            Array.Fill(currentlyInStack, false);

            for (int i = 0; i < edges.Length; i++)
            {
                if (visited[i])
                    continue;
                if (isNodeInCycle(i, edges, visited, currentlyInStack))
                    return true;
            }
            return false;
        }

        public static bool isNodeInCycle(int node, int[][] edges, bool[] visited, bool[] currentlyInStack)
        {
            visited[node] = true;
            currentlyInStack[node] = true;

            bool containsCycle = false;
            int[] neighbours = edges[node];
            foreach (var neighbour in neighbours)
            {
                if (!visited[neighbour])
                    containsCycle = isNodeInCycle(neighbour, edges, visited, currentlyInStack);
                if (containsCycle || currentlyInStack[neighbour])
                    return true;
            }
            currentlyInStack[node] = false;
            return false;
        }
    }
}