public class Solution {
    public int RemoveElement(int[] nums, int val) {
        var len = nums.Length;
        if (len == 0)
            return 0;
        var i = 0;
        while (true) {
            if (nums[i] == val) {
                for (var j=i+1; j < len; ++j) {
                    nums[j-1] = nums[j];
                }
                len--;                
            } else {
                ++i;
            }
            if (i == len)
                break;
        }
        
        return len;
    }
}