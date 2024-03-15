namespace Youngest_Common_Ancestor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Youngest Common Ancestor");
        }
        //O(d) time / O(1) space
        public static AncestralTree GetYoungestCommonAncestor(AncestralTree topAncestor,AncestralTree descendantOne,AncestralTree descendantTwo)
        {
            // Write your code here.
            int depthOne = getDepth(descendantOne, topAncestor);
            int depthTwo = getDepth(descendantTwo, topAncestor);
            if (depthOne > depthTwo)
                return MoveDescendantsToSameLevel(descendantOne, descendantTwo, depthOne - depthTwo);
            return MoveDescendantsToSameLevel(descendantTwo, descendantOne, depthTwo - depthOne); ;
        }
        public static AncestralTree MoveDescendantsToSameLevel(AncestralTree lower, AncestralTree higher, int diff)
        {
            //move the lower to the higher level
            while (diff > 0)
            {
                lower = lower.ancestor;
                diff--;
            }
            //move both nodes together
            while (lower != higher)
            {
                lower = lower.ancestor;
                higher = higher.ancestor;
            }
            return lower;
        }
        public static int getDepth(AncestralTree descendant, AncestralTree topAncestor)
        {
            int depth = 0;
            while (descendant != topAncestor)
            {
                depth++;
                descendant = descendant.ancestor;
            }
            return depth;
        }

        public class AncestralTree
        {
            public char name;
            public AncestralTree ancestor;

            public AncestralTree(char name)
            {
                this.name = name;
                this.ancestor = null;
            }

            // This method is for testing only.
            public void AddAsAncestor(AncestralTree[] descendants)
            {
                foreach (AncestralTree descendant in descendants)
                {
                    descendant.ancestor = this;
                }
            }
        }
    }
}