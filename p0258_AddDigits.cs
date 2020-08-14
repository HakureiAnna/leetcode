public class Solution {
    public int AddDigits(int num) {
        return num - 9 * ((num-1)/9);
    }
}