public class Solution {
    public int CountOdds(int low, int high) {
        var odds = (high - low)/2;
        if (high % 2 == 1 || low % 2 == 1)
            odds++;
        return odds;
    }
}