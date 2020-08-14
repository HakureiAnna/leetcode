public class Solution {
       public void MoveZeroes(int[] nums)
        {
            var len = nums.Length;
            if (len < 2)
                return;

            var writeIndex = 0;

            for (var i = 0; i < len; ++i)
            {
                if (nums[i] != 0)
                {
                    nums[writeIndex++] = nums[i];
                }
            }
            for (var i = writeIndex; i < len; ++i)
                nums[i] = 0;
        }
}