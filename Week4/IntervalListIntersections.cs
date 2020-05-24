using System.Collections.Immutable;
using System.Xml.Linq;
using System.Linq;
using System.Collections.Generic;
using System;

namespace Leetcode_May_Challenge.Week4
{
    public class IntervalListIntersections
    {
        public int[][] IntervalIntersection(int[][] A, int[][] B)
        {
            var result = new List<int[]>();
            foreach (var pairOfA in A)
            {
                foreach (var pairOfB in B)
                {
                    if (pairOfB[0] <= pairOfA[1] && pairOfA[0] <= pairOfB[1])
                    {
                        int[] intersection = new int[2];
                        intersection[0] = pairOfA[0] > pairOfB[0] ? pairOfA[0] : pairOfB[0];
                        intersection[1] = pairOfA[1] < pairOfB[1] ? pairOfA[1] : pairOfB[1];
                        result.Add(intersection);
                    }
                    else
                    {
                        
                    }
                }
            }
            return result.ToArray();
        }
    }
}
