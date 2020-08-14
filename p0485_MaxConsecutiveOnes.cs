public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        var max = Int32.MinValue;
        var count = 0;
        foreach (var n in nums) {
            if (n == 1) {
                count++;
            } else {
                count = 0;
            }
            
            if (count > max) {
                max = count;
            }
        }
        return max;
    }
}