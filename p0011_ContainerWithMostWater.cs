public class Solution {
        public int MaxArea(int[] height)
        {
            int max = 0;
            int l = 0;
            int r = height.Length - 1;
            int h = 0;
            int w = 0;
            int a = 0;
            int lH, rH;
            while (l < r)
            {
                lH = height[l];
                rH = height[r];
                h = lH > rH? rH: lH;
                w = r - l;
                if (lH == h)
                    l++;
                else if (rH == h)
                    r--;
                a = w * h;
                if (max < a)
                {
                    max = a;
                }
            }
            return max;
        }
}