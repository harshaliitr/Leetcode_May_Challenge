using System.Linq;
using System;

namespace Leetcode_May_Challenge.Week2
{
    public class RemoveKDigits
    {
        /*  
            1
            4
            3
            2     1
            2     2  
            1     1  
            9     9
            ---------------
            1
            2      1
            3      2
            4      3
            5      4
            ----------------
            5
            4      4
            3      3
            2      2 
            1      1
        */
        public string Remove(string num, int k)
        {
            int currentLength = num.Length;
            int finalLength = currentLength - k;
            if (finalLength == 0)
                return "0";
            string result = "";
            int startIndex = 0;
            int indexOfNumberLastPicked = -1;
            while (finalLength-- > 0)
            {
                string subNum = num.Substring(startIndex, k + 1);
                char x = 'z';
                int count = 0;
                foreach (char c in subNum)
                {
                    if (c < x && (startIndex + count) > indexOfNumberLastPicked)
                    {
                        x = c;
                        indexOfNumberLastPicked = startIndex + count;
                    }
                    count++;
                }
                startIndex++;
                result += x;
            }
            return result.TrimStart('0') == "" ? "0" : result.TrimStart('0');
        }
    }
}
