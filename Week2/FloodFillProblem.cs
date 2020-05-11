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
            image = FloodFillRecursive(image, sr, sc, newColor, currentColor);
            return image;
        }
        private int[][] FloodFillRecursive(int[][] image, int sr, int sc, int newColor, int startColor)
        {
            var rows = image.Length;
            var columns = image[0].Length;

            if (sr >= rows || sr < 0 || sc >= columns || sc < 0)
                return image;

            if (image[sr][sc] == startColor)
                image[sr][sc] = newColor;
            else
                return image;

            FloodFillRecursive(image, sr - 1, sc, newColor, startColor); // left
            FloodFillRecursive(image, sr + 1, sc, newColor, startColor); // right
            FloodFillRecursive(image, sr, sc - 1, newColor, startColor); // up
            FloodFillRecursive(image, sr, sc + 1, newColor, startColor); // down
            return image;
        }
    }
}
