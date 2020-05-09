using System.Linq;

namespace Leetcode_May_Challenge.Week2
{
    public static class ValidPerfectSquare
    {
        public static bool IsPerfectSquare(int num)
        {
            foreach (int i in Enumerable.Range(1, 46340))
            {
                if (i > (num / 2) + 1)
                    break;
                if (i * i == num)
                {
                    return true;
                }
            }
            // Console.WriteLine(Math.Sqrt(Int32.MaxValue)); 2147483647; 46340.950001051984

            return false;
        }

    }
}
