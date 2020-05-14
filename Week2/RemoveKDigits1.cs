using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode_May_Challenge.Week2
{
    public class RemoveKDigits1
    {
        public string Remove(string num, int k)
        {
            int len = num.Length;
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < len; i++)
            {
                while (k > 0 && stack.Count > 0 && num[stack.Peek()] > num[i])
                {
                    stack.Pop();
                    k--;
                }
                stack.Push(i);
            }

            StringBuilder sb = new StringBuilder();
            while (stack.Count > 0)
            {
                sb.Append(num[stack.Pop()]);
                if (k-- > 0) sb.Length--;
            }

            StringBuilder output = new StringBuilder();
            for (int i = sb.Length - 1; i >= 0; i--)
            {
                output.Append(sb[i]);
            }

            return output.ToString().TrimStart('0') == "" ? "0" : output.ToString().TrimStart('0');
        }
    }
}
