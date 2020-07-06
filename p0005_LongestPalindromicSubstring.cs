public class Solution {
        public string LongestPalindrome(string s)
        {
            var k = 0;
            var l = 0;
            bool isPalindrome = true;
            for (var i=s.Length; i> 0; --i)
            {
                for (var j=s.Length-i; j>=0; --j)
                {
                    k = j;
                    l = j + i - 1;
                    isPalindrome = true;
                    while (k < l)
                    {
                        if (s[k] != s[l])
                        {
                            isPalindrome = false;
                            break;
                        }
                        k++;
                        l--;
                    }
                    if (isPalindrome)
                    {
                        return s.Substring(j, i);
                    }
                }
            }
            return "";
        }
}