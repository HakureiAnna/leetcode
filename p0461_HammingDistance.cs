public class Solution {
    public int HammingDistance(int x, int y) {
        int diff = x ^ y;
        int sum = 0;
        while (diff > 0) {
            sum += diff & 0x1;
            diff >>= 1;
        }
        return sum;
    }
}