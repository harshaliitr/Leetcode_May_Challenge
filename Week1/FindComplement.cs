using System;

namespace Leetcode_May_Challenge.Week1
{
    public class FindComplement
    {
        public int Find(int num)
        {
            int number_of_bits = (int)(Math.Floor(
                       Math.Log(num) / Math.Log(2))) + 1;

            return ((1 << number_of_bits) - 1) ^ num;
        }
    }
}
