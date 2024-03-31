namespace Suffix_Trie_Construction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SuffixTrie suffixTrie = new SuffixTrie("babc");
        }
        public class TrieNode
        {
            public Dictionary<char, TrieNode> Children =
              new Dictionary<char, TrieNode>();
        }

        public class SuffixTrie
        {
            public TrieNode root = new TrieNode();
            public char endSymbol = '*';

            public SuffixTrie(string str)
            {
                PopulateSuffixTrieFrom(str);
            }
            //O(n^2) time / O(n^2) space
            public void PopulateSuffixTrieFrom(string str)
            {
                // Write your code here.
                for (int i = 0; i < str.Length; i++)
                {
                    TrieNode node = root;
                    for (int j = i; j < str.Length; j++)
                    {
                        char letter = str[j];
                        if (!node.Children.ContainsKey(letter))
                        {
                            TrieNode newNode = new TrieNode();
                            node.Children.Add(letter, newNode);
                        }
                        node = node.Children[letter];
                    }
                    node.Children[endSymbol] = null;
                }
            }
            //O(n) time / O(1) space
            public bool Contains(string str)
            {
                // Write your code here.
                TrieNode node = root;
                for (int i = 0; i < str.Length; i++)
                {
                    char letter = str[i];
                    if (!node.Children.ContainsKey(letter))
                    {
                        return false;
                    }
                    node = node.Children[letter];
                }
                return node.Children.ContainsKey(endSymbol);
            }
        }
    }
}