public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int k = 0;
        int longest = 0;
        int[] counts;
        int id;
        int count = 0;
        for (var i = 0; i < s.Length; ++i)
        {
            counts = new int[128];
            counts[s[i]]++;
            count = 1;
            k = i + 1;
            if (k == s.Length)
                break;
            id = s[k];
            while (counts[id] == 0)
            {
                counts[id]++;
                k++;
                count++;
                if (k == s.Length)
                    break;
                id = s[k];
            }
            if (count > longest)
            {
                longest = count;
            }
        }
        if (count > longest)
        {
            longest = count;
        }

        return longest;
    }
}