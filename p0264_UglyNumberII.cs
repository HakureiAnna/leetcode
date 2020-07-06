public class Solution {
    public int NthUglyNumber(int n) {
        var i2 = 0;
        var i3 = 0;
        var i5 = 0;
        var ugly = new int[n];
        ugly[0] = 1;
        var next2 = ugly[i2] * 2;
        var next3 = ugly[i3] * 3;
        var next5 = ugly[i5] * 5;
        
        for (var i=1; i<n; ++i) {
            ugly[i] = Math.Min(next2, Math.Min(next3, next5));
            if (ugly[i] == next2) {
                i2++;
                next2 = ugly[i2] * 2;
            }
            if (ugly[i] == next3) {
                i3++;
                next3 = ugly[i3] * 3;
            } 
            if (ugly[i] == next5) {
                i5++;
                next5 = ugly[i5] * 5;
            }
        }
        return ugly[n-1];
    }
}