public class Solution {
    public int ArrangeCoins(int n) {
        // k(k+1)/2 <= n
        // k2+k <= 2n
        // k^2+k+(1/2)^2-(1/2)^2 <= 2n
        // (k+1/2)^2 <= 2n + 1/4
        // k+1/2 <= (8n+1)^(1/2)/2
        // k <= ((8n-1)^(1/2)-1)/2
        long nl = n;
        int k = (int)((Math.Sqrt(8 * nl +1) - 1)/2);
        return k;
    }
}