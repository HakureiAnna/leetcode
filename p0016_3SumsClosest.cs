public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        Array.Sort(nums);
        var len = nums.Length;
        
        var minDiff = Int32.MaxValue;
        var minSum = Int32.MaxValue;
        for (var i=0; i < len-2; ++i) {
            var num = nums[i];
            var j = i + 1;
            var k = len - 1;
            var sum = num + nums[j] + nums[k];
            var diff = Math.Abs(target - sum);
            while (j < k) {
                if (diff < minDiff)
                {
                    minDiff = diff;
                    minSum = sum;
                } else if (diff == 0)
                    return target;
                if (sum < target) {
                    j++;
                } else if (sum > target) {
                    k--;
                } 
                sum = num + nums[j] + nums[k];
                diff = Math.Abs(target - sum);
            }
        }
        return minSum;
    }
}