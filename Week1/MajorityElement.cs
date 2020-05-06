using System.Linq;
using System.Collections.Generic;
using System;

namespace Leetcode_May_Challenge.Week1
{
    public static class MajorityElement
    {
        public static int FindMajorityElement(int[] nums)
        {
            var size = nums.Length;
            if (size == 1)
                return nums[0];
            var dict = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                var count = dict.GetValueOrDefault(num, 0);
                if (count >= nums.Length / 2)
                    return num;
                dict[num] = count + 1;
            }
            return -1;
        }
    }
}
