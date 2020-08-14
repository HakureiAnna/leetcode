public class Solution {
    public int FindNumbers(int[] nums) {
        int count = 0;
        for (var i=0; i<nums.Length; ++i) {
            var digits = 0;
            while (nums[i] > 0) {
                nums[i] /= 10;
                ++digits;
            }
            if (digits % 2 == 0)
                ++count;
        }
        return count;
    }
}