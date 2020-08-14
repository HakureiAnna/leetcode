public class Solution {

        public int HIndex(int[] citations)
        {
            var len = citations.Length + 1;
            var counts = new int[len];
            foreach (var cite in citations)
            {
                for (var i=1; i<len; ++i)
                {
                    if (cite >= i)
                        counts[i]++;
                }
            }
            for (var i=len-1; i>0; --i)
            {
                if (counts[i] >= i)
                    return i;
            }
            return 0;
        }
}