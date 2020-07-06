public class Solution {
        public int Reverse(int x)
        {
            var negative = x < 0;
            x *= negative ? -1 : 1;
            long result = 0;
            while (x > 0)
            {
                result *= 10;
                result += x % 10;
                x /= 10;
            }
            if (result > Int32.MaxValue)
                result = 0;
            result *= negative ? -1 : 1;
            return (int)result;
        }
}