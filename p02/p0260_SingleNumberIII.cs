public class Solution {
        public int[] SingleNumber(int[] nums)
        {
            var uniques = new int[2];
            var freq = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (freq.ContainsKey(num))
                    freq[num]++;
                else
                    freq[num] = 1;
            }
            var i = 0;
            foreach (var key in freq.Keys)
                if (freq[key] == 1)
                    uniques[i++] = key;

            return uniques;
        }
}