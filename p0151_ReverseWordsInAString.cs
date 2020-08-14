public class Solution {
        public string ReverseWords(string s)
        {
            var parts = s.Split(' ');
            var sb = new StringBuilder();
            for (var i = parts.Length - 1; i >= 0; --i)
            {
                var part = parts[i].Trim();
                if (part.Length > 0)
                {
                    sb.Append(part);
                    if (i > 0)
                        sb.Append(' ');
                }
            }
            return sb.ToString().Trim();
        }
}