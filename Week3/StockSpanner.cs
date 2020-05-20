using System.Linq;
using System.Collections.Generic;
using System;

namespace Leetcode_May_Challenge.Week3
{
    public class StockSpanner
    {
        private List<int> priceList;
        private int lastSpan;
        public StockSpanner()
        {
            priceList = new List<int>();
        }

        public int Next(int price)
        {
            var lastPrice = priceList.LastOrDefault();
            var result = lastSpan;
            priceList.Add(price);
            if (price < lastPrice)
            {
                result = 1;
            }
            else
            {
                int startIndex = priceList.Count - lastSpan - 1;
                for (int p = startIndex; p >= 0; p--)
                {
                    if (price >= priceList[p])
                        result++;
                    else
                        break;
                }
            }
            lastSpan = result;
            return result;
        }
    }
}
