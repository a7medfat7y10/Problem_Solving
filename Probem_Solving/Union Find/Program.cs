namespace Union_Find
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UnionFind unionFind= new UnionFind();
            unionFind.CreateSet(5);
            unionFind.CreateSet(10);
            unionFind.Find(5);
            unionFind.Find(10);
            unionFind.Union(5,10);
            unionFind.Find(5);
            unionFind.Find(10);
            unionFind.CreateSet(20);
            unionFind.Find(20);
            unionFind.Union(20, 10);
            unionFind.Find(5);
            unionFind.Find(10);
            unionFind.Find(20);
        }
        public class UnionFind
        {
            // Write your code here.
            private Dictionary<int, int> parents = new Dictionary<int, int>();
            //O(1) time / O(1) space
            public void CreateSet(int value)
            {
                // Write your code here.
                parents[value] = value;
            }
            //O(n) time / O(1) space
            public int? Find(int value)
            {
                // Write your code here.
                if (!parents.ContainsKey(value))
                    return null;
                int currentParent = value;
                while (currentParent != parents[currentParent])
                {
                    currentParent = parents[currentParent];
                }
                return currentParent;
            }
            //O(n) time / O(1) space
            public void Union(int valueOne, int valueTwo)
            {
                // Write your code here.
                if (!parents.ContainsKey(valueOne) || !parents.ContainsKey(valueTwo))
                    return;
                int setOneParent = (int)Find(valueOne);
                int setTwoParent = (int)Find(valueTwo);
                parents[setTwoParent] = setOneParent;
            }
        }
        //Another Solution with more optimized time complexity
        public class UnionFindV2
        {
            // Write your code here.
            private Dictionary<int, int> parents = new Dictionary<int, int>();
            private Dictionary<int, int> ranks = new Dictionary<int, int>();
            //O(1) time / O(1) space
            public void CreateSet(int value)
            {
                // Write your code here.
                parents[value] = value;
                ranks[value] = 0;
            }
            //O(alpha(n)) time / O(1) space
            public int? Find(int value)
            {
                // Write your code here.
                if (!parents.ContainsKey(value))
                    return null;
                if (value != parents[value])
                {
                    parents[value] = (int)Find(parents[value]);
                }
                return parents[value];
            }
            //O(alpha(n)) time / O(1) space
            public void Union(int valueOne, int valueTwo)
            {
                // Write your code here.
                if (!parents.ContainsKey(valueOne) || !parents.ContainsKey(valueTwo))
                    return;
                int setOneParent = (int)Find(valueOne);
                int setTwoParent = (int)Find(valueTwo);
                if (ranks[setOneParent] < ranks[setTwoParent])
                    parents[setOneParent] = setTwoParent;
                else if (ranks[setOneParent] > ranks[setTwoParent])
                    parents[setTwoParent] = setOneParent;
                else
                {
                    parents[setTwoParent] = setOneParent;
                    ranks[setOneParent]++;
                }
            }
        }
    }
}