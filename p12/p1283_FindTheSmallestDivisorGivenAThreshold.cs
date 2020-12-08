public class Solution {
    public int SmallestDivisor(int[] nums, int threshold) {
        int min = 1;
        int max = (int)1e6;
        int mid = 0;
        var result = threshold + 1;
        while (min < max) {
            mid = (max+min)/2;
            var current = 0;
            foreach (var x in nums) {
                current += (x + mid - 1)/mid;
            }
            if (current > threshold) {
                min = mid + 1;
            } else {
                max = mid;
            }
        }
        return min;
    }
}