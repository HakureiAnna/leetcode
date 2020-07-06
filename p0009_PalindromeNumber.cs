public class Solution {
    public bool IsPalindrome(int x) {
        var tmp = String.Format("{0}", x);
        int i = 0;
        int j = tmp.Length - 1;
        while (i < j) {
            if (tmp[i] != tmp[j])
                return false;
            ++i;
            --j;
        }
        return true;
    }
}