public class Solution {

        int[] dp;
        public int MincostTickets(int[] days, int[] costs)
        {
            dp = new int[days.Length];
            return computeCost(days, costs, 0);
        }

        public int computeCost(int[] days, int[] costs, int day)
        {
            var len = days.Length;
            if (day >= len)
                return 0;
            if (dp[day] != 0)
                return dp[day];
            int cost1 = computeCost(days, costs, day + 1) + costs[0];
            var i = day + 1;
            for (; i<len; ++i)
                if (days[i] - days[day] >= 7)
                    break;
            int cost7 = computeCost(days, costs, i) + costs[1];
            i = day + 1;
            for (; i < len; ++i)
                if (days[i] - days[day] >= 30)
                    break;
            int cost30 = computeCost(days, costs, i) + costs[2];
            return dp[day] = Math.Min(cost1, Math.Min(cost7, cost30));
        }
}