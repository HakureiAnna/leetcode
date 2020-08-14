public class Solution {
        public int RangeSum(int[] nums, int n, int left, int right)
        {
            var sums = new List<int>();
            var sum = 0;
            var len = nums.Length;
            for (var i=0; i<len; ++i)
            {
                sum = 0;
                for (var j=i; j<len; ++j)
                {
                    sum += nums[j];
                    sums.Add(sum);
                }
            }

            sums.Sort();

            sum = 0;
            for (var i = left - 1; i < right; ++i)
                sum += sums[i];
            return sum;
        }
}