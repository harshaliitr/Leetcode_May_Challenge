using System.Collections.Generic;
using System;
using System.Linq;

namespace Leetcode_May_Challenge.Week2
{
    public class Trie
    {
        const int charSize = 26;
        bool isLeaf;
        List<Trie> children;
        public Trie()
        {
            isLeaf = false;
            children = new List<Trie>();

            foreach (int i in Enumerable.Range(0, charSize))
            {
                children.Add(null);
            }
        }

        /** Inserts a word into the trie. */
        public void Insert(string word)
        {
            var chars = word.ToCharArray();
            Trie current = this;
            for (int i = 0; i < word.Length; i++)
            {
                if (current.children[chars[i] - 'a'] == null)
                {
                    current.children[chars[i] - 'a'] = new Trie();
                }
                current = current.children[chars[i] - 'a'];
            }
            current.isLeaf = true;
        }

        /** Returns if the word is in the trie. */
        public bool Search(string word)
        {
            Trie current = this;
            var chars = word.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                current = current.children[chars[i] - 'a'];
                if (current == null)
                    return false;
            }
            return current.isLeaf;
        }

        /** Returns if there is any word in the trie that starts with the given prefix. */
        public bool StartsWith(string prefix)
        {
            Trie current = this;
            var chars = prefix.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                current = current.children[chars[i] - 'a'];
                if (current == null)
                    return false;
            }
            return true;
        }
    }
}
