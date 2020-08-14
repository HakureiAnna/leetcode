public class Solution {        

        public int TitleToNumber(string s)
        {
            var val = 0;
            for (var i=0; i<s.Length; ++i)
            {
                val = val * 26 + s[i] - 'A' + 1;
            }
            return val;
        }
}