public class Solution {
    public bool IsPowerOfFour(int num) {
        if (num == 0)
            return false;
        var pow = (int)(Math.Log(num)/Math.Log(4));
        return Math.Pow(4, pow) == num;
    }
}