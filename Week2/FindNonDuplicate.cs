using System;

namespace Leetcode_May_Challenge.Week2
{
    public class FindNonDuplicate
    {
        /* [1,1,2,3,3,4,4,8,8]
        1) Find the middle index, say ‘mid’.
        2) If mid is even, then compare arr[mid] and arr[mid + 1]. 
            If both are same, then the required element exists after mid else before mid.
        3) If mid is odd, then compare arr[mid] and arr[mid – 1]. 
            If both are same, then the required element exists after mid else before mid.
        */
        public int SingleNonDuplicate(int[] nums)
        {
            int l = 0;
            int r = nums.Length - 1;
            while (l < r)
            {
                int mid = l + (r - l) / 2;
                if (mid % 2 == 0)
                {
                    if (nums[mid] == nums[mid + 1])
                        l = mid + 2;
                    else
                        r = mid;
                }
                else
                {
                    if (nums[mid] == nums[mid - 1])
                        l = mid + 1;
                    else
                        r = mid - 1;
                }
            }
            return nums[l];
        }
    }
}
