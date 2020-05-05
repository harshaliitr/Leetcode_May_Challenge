using System;

namespace Leetcode_May_Challenge.Week1
{
    public static class FirstUniqueCharacter
    {
        public static int FirstUniqChar(string s)
        {
            int[] charArr = new int[26];
            foreach (char c in s)
            {
                charArr[c - 'a'] += 1;
            }
            int index = 0;
            foreach (char c in s)
            {
                if (charArr[c - 'a'] == 1)
                    return index;
                index += 1;
            }

            return -1;
        }
    }
}
