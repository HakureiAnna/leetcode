public class Solution {
      public int NumIdenticalPairs(int[] nums)
        {
            var len = nums.Length;
            var count = 0;
            for (var i = 0; i < len - 1; ++i)
                for (var j = i + 1; j < len; ++j)
                    if (nums[i] == nums[j])
                        count++;

            return count;
        }
}