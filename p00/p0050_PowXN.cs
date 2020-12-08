public class Solution {
    public double MyPow(double x, int n) {
        long m = n;
        if (m == 0)
            return 1;
        
        double result = 1;
        
        if (m < 0) {
            x = 1/x;
            m *= -1;
        }
        
        while (m > 0) {
            if ((m & 0x1) == 0) {
                x *= x;
                m >>= 1;
            } else {
                result *= x;  
                m--;              
            }
        }
        return result;
    }
}