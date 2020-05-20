using System.Collections.Generic;
using System.Linq;
using System;

namespace Leetcode_May_Challenge.Week3
{
    public class FindAllAnagrams
    {
        // abc

        public IList<int> FindAnagrams(string s, string p)
        {
            var result = new List<int>();
            for (int i = 0; i <= s.Length - p.Length; i++)
            {
                string sub = s.Substring(i, p.Length);
                if (areAnagrams(sub, p))
                {
                    result.Add(i);
                }
            }

            return result;
        }
        public bool areAnagrams(String s1, String s2)
        {
            int[] lookup = new int[26];
            foreach (char c in s1)
            {
                lookup[c - 'a']++;
            }
            foreach (char c in s2)
            {
                lookup[c - 'a']--;
            }
            for (int i = 0; i < 26; i++)
            {
                if (lookup[i] != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
