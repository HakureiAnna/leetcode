public class Solution {
        public int RemoveDuplicates(int[] nums)
        {
            var len = nums.Length;

            if (len < 2)
                return len;

            var writeIndex = 1;
            for (var readIndex=1; readIndex < len; ++readIndex)
            {
                if (nums[readIndex] != nums[readIndex-1])
                {
                    nums[writeIndex++] = nums[readIndex];
                }
            }

            return writeIndex;
        }
}