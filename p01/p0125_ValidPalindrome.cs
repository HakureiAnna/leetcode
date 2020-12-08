public class Solution {        public bool IsPalindrome(string s)
        {
            var i = 0;
            var j = s.Length - 1;
            while (i < j)
            {
                while (i < s.Length && !isAlphaNum(toLower(s[i])))
                    i++;
                while (j >= 0 && !isAlphaNum(toLower(s[j])))
                    j--;
                if (i > j)
                    return true;
                if (toLower(s[i]) != toLower(s[j]))
                    return false;
                i++;
                j--;
            }
            return true;
        }

        public bool isAlphaNum(char ch)
        {
            return (ch >= 'a' && ch <= 'z') || (ch >= '0' && ch <= '9');
        }

        public char toLower(char ch)
        {
            if (ch >= 'A' && ch <= 'Z')
                ch += (char)('a' - 'A');
            return ch;
        }
}