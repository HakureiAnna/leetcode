public class Solution {

    
    IDictionary<string, int> refTbl = new Dictionary<string, int>();
    public int PalindromePartition(string s, int k) {
        if (k == s.Length)
            return 0;
        int[][] memo = new int[k][];
        for (var i=0; i<memo.Length; ++i) {
            memo[i] = new int[s.Length+1];
        }
        for (var i=0; i<s.Length; ++i) {
            memo[0][i+1] = checkPalindrome(s.Substring(0, i + 1));
        }

        for (var i=1; i<k; ++i) {
            for (var j=i; j<=s.Length; ++j) {
                int cur = int.MaxValue;
                for (int p=j; p>=i; --p) {
                    cur = Math.Min(cur, memo[i-1][p-1] + checkPalindrome(s.Substring(p-1,j-p+1)));                    
                }
                memo[i][j] = cur;
            }
        }

        return memo[k-1][s.Length];
    }

    public int checkPalindrome(string s) {
        
        int mid = s.Length / 2;
        int changes = 0;
        for (var i = 0; i< mid; ++i) {
            if (s[i] != s[s.Length - i - 1])
                changes++;
        }
        if (refTbl.ContainsKey(s)) {
            refTbl[s] = changes;
        }
        return changes;
    }

}