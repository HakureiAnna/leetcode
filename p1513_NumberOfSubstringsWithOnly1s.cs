public class Solution {
        public int NumSub(string s)
        {
            var len = s.Length;
            long count = 0;
            var conseq = 0;
            for (var i = 0; i < len; ++i)
            {
                if (s[i] == '1')
                {
                    conseq++;
                    count += conseq;
                }
                else
                {
                    conseq = 0;
                }
            }

            return (int)(count % (1000000000 + 7));
        }
}