using System.Linq;
using System.Collections.Generic;
using System;

namespace Leetcode_May_Challenge.Week3
{
    public class StockSpanner1
    {
        private int count;
        private Dictionary<int, Tuple<int, int>> spanDict;

        public StockSpanner1()
        {
            spanDict = new Dictionary<int, Tuple<int, int>>();
            count = 0;
        }

        public int Next(int price)
        {
            int span = 0;
            int startIndex = count;
            int result = 1;

            int search(int startIndex)
            {
                int lastPrice;
                if (spanDict.TryGetValue(startIndex, out var last))
                {
                    lastPrice = last.Item1;
                    if (lastPrice > price)
                    {
                        return result;
                    }
                    result += last.Item2;
                    startIndex -= last.Item2;
                    search(startIndex);
                }
                return result;
            };
            span = search(count - 1);
            spanDict.TryAdd(count, new Tuple<int, int>(price, span));
            count++;
            return span;
        }
    }
}
