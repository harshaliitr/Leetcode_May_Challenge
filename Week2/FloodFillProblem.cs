using System;

namespace Leetcode_May_Challenge.Week2
{
    // [ [1,1,1] [1,1,0] [1,0,1]]
    // [1 1 1]        [2 2 2]
    // [1 1 0]  ----> [2 2 0]
    // [1 0 1]        [2 0 1]
    public class FloodFillProblem
    {
        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            var currentColor = image[sr][sc];
            if (currentColor == newColor)
                return image;
            var rows = image.Length;
            var columns = image[0].Length;
            return FloodFillRecursive(sr, sc);

            int[][] FloodFillRecursive(int sr, int sc)
            {
                if (sr >= rows || sr < 0 || sc >= columns || sc < 0 || image[sr][sc] != currentColor)
                    return image;

                if (image[sr][sc] == currentColor)
                    image[sr][sc] = newColor;

                FloodFillRecursive(sr - 1, sc); // left
                FloodFillRecursive(sr + 1, sc); // right
                FloodFillRecursive(sr, sc - 1); // up
                FloodFillRecursive(sr, sc + 1); // down
                return image;
            }
        }
    }
}
