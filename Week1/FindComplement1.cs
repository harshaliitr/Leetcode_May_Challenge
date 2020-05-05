using System;

namespace Leetcode_May_Challenge.Week1
{
    public class FindComplement1
    {
        public int FindComplement(int num)
        {
            int k = 1;
            for (int i = num; i > 0; i >>= 1)
                k <<= 1;
            return k - num - 1;
        }
    }
}
