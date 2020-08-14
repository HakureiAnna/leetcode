public class Solution {
    public int NumWaterBottles(int numBottles, int numExchange) {
        var full = numBottles;
        var empty = 0;
        var drank = 0;
        while (full != 0) {
            drank += full;
            empty += full;
            full = empty / numExchange;
            empty %= numExchange;
        }
        return drank;
    }
}