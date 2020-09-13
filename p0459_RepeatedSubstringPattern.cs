public class Solution {        
        public bool RepeatedSubstringPattern(string s)
        {
            var len = s.Length;
            for (var i=1; i <= len/2; ++i)
            {
                if (traverse(s, 0, i))
                    return true;
            }
            return false;
        }

        public bool traverse(string s, int i, int len)
        {
            if (s.Length - i < len)
                return false;
            for (var j=0; j<len; ++j)
            {
                if (s[j] != s[j + i])
                {
                    return false;
                }
            }
            if (s.Length - i == len)
                return true;
            return traverse(s, i + len, len);
        }
}