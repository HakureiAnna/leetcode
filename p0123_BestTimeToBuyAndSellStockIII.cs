public class Solution {       
    public int MaxProfit(int[] prices)
        {
            var len = prices.Length;
        if (len == 0)
            return 0;
            var left = new int[len];
            var right = new int[len];
            var minLeft = prices[0];
            var maxRight = prices[len-1];
            for (var i=1; i<len; ++i)
            {
                minLeft = Math.Min(minLeft, prices[i]);
                left[i] = Math.Max(left[i - 1], prices[i] - minLeft);
            }
            for (var i=len-2; i>=0; --i)
            {
                maxRight = Math.Max(maxRight, prices[i]);
                right[i] = Math.Max(right[i + 1], maxRight - prices[i]);
            }
            var max = 0;
            for (var i=0; i<len; ++i)
            {
                max = Math.Max(max, left[i] + right[i]);
            }
            return max;
        }
}