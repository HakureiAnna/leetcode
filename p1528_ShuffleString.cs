public class Solution {
        public string RestoreString(string s, int[] indices)
        {
            var str = new char[s.Length];
            for (var i=0; i<str.Length; ++i)
            {
                str[indices[i]] = s[i];
            }
            return new string(str);
        }
}