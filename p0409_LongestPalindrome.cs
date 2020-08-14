public class Solution {
    public int LongestPalindrome(string s) {
        var counts = new int[52];
        foreach (var ch in s) {
            if (ch >= 'a' && ch <= 'z')
                counts[ch-'a']++;
            else if (ch >= 'A' && ch <= 'Z')
                counts[ch-'A'+26]++;
        }
        var maxLen = 0;
        var odd = false;
        foreach (var count in counts) {
            maxLen += count / 2 * 2;
            if (count % 2 != 0)
                odd = true;
        }
        if (odd)
            maxLen++;
        return maxLen;
    }
}