using System.Linq;
using System.Collections.Generic;
using System;

namespace Leetcode_May_Challenge.Week2
{
    public class FindTownJudge
    {
        public int FindJudge(int N, int[][] trust)
        {
            if (N == 1)
                return 1;
            var trustDict = new Dictionary<int, List<int>>();
            for (int i = 0; i < trust.Length; i++)
            {
                int a = trust[i][0];
                int b = trust[i][1];
                if (trustDict.ContainsKey(a))
                {
                    trustDict[a].Add(b);
                }
                else trustDict[a] = new List<int>() { b };
            }
            var townJudge = new HashSet<int>();
            foreach (var item in trustDict[trustDict.Keys.FirstOrDefault()])
            {
                townJudge.Add(item);
            }
            // if (townJudge.Count == 0)
            //     return -1;
            foreach (var item in trustDict)
            {
                townJudge.IntersectWith(item.Value);
                if (townJudge.Count == 0)
                    return -1;
            }
            int[] result = new int[1];
            if (townJudge.Count == 1)
            {
                townJudge.CopyTo(result);
                return result[0];
            }
            return -1;
        }
    }
}
