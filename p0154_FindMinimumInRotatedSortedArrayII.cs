public class Solution {
        public int FindMin(int[] nums)
        {

            for (var i = nums.Length-1; i > 0; --i)
                if (nums[i-1] > nums[i])
                    return nums[i];
            return nums[0];
        }
}