public class Solution {
        public int MinFlips(string target)
        {
            var len = target.Length;
            var bulbs = new bool[len];
            var goal = new bool[len];
            var count = 0;
            for (var i=0; i<len; ++i)
            {
                goal[i] = (target[i] - '0') == 1;
            }

            for (var i=len-1; i>0; --i)
            {
                if (goal[i] != goal[i - 1])
                {
                    count++;
                }
            }
            if (goal[0] != bulbs[0])
            {
                count++;
            }

            return count;
        }
}