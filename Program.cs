using System;
using Leetcode_May_Challenge.Week1;
using Leetcode_May_Challenge.Week2;

namespace Leetcode_May_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Console.WriteLine(MajorityElement.FindMajorityElement(new int[] { 2147483647 }));
            var image = new int[3][];
            image[0] = new int[3] { 1, 1, 1 };
            image[1] = new int[3] { 1, 1, 0 };
            image[2] = new int[3] { 1, 0, 1 };
            Console.WriteLine(new FloodFillProblem().FloodFill(image, 1, 1, 2));
        }
    }
}
