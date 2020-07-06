public class Solution {
        public int[] TwoSum(int[] nums, int target)
        {
            var len = nums.Length;
            for (var i = 0; i < len; ++i)
            {
                var diff = target - nums[i];
                var j = Array.IndexOf(nums, diff);
                if (j >= 0 && j != i)
                    return new int[] { i, j };

            }
            return null;
        }
}