using System;

namespace Leetcode_May_Challenge.Week2
{
    // (x1, y1) (x2, y2)
    // y = (y2-y1)/(x2-x1) * (x - x1) + y1
    public class StraightLine
    {
        public bool CheckStraightLine(int[][] coordinates)
        {
            Tuple<int, int> p1 = new Tuple<int, int>(coordinates[0][0], coordinates[0][1]);
            Tuple<int, int> p2 = new Tuple<int, int>(coordinates[1][0], coordinates[1][1]);
            int slope = (p2.Item1 - p1.Item1) != 0 ? (p2.Item2 - p1.Item2) / (p2.Item1 - p1.Item1) : Int32.MaxValue;

            for (int i = 2; i < coordinates.Length; i++)
            {
                int x = coordinates[i][0];
                int y = coordinates[i][1];
                if (!yCoordinatePresent(x, y, p1.Item1, p1.Item2, slope))
                    return false;
            }
            return true;
        }
        private bool yCoordinatePresent(int x, int y, int x1, int y1, int slope)
        {
            if (slope == Int32.MaxValue)
                return x == x1;
            return y == slope * (x - x1) + y1;
        }
    }
}
