public class Solution {
    public int NumOfSubarrays(int[] arr) {
        var sum = 0;
        var counts = new long[2];
        counts[0] = 1;
        for (var i=0; i<arr.Length; ++i) {
            sum = (sum + arr[i])%2;
            counts[sum]++;
        }
        var result = counts[0] * counts[1];
        result %= (1000000000l + 7);
        return (int)result;
    }
}