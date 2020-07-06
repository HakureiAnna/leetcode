public class Solution {
 public bool CanArrange(int[] arr, int k)
        {
            var freqs = new int[k];
            var curr = 0;
            foreach (var i in arr)
            {
                if (i < 0)
                {
                    curr = k + (i % k);
                    if (curr == k)
                        curr = 0;
                } else
                {
                    curr = i % k;
                }
                freqs[curr]++;
            }
            var sums = 0;
            if (freqs[0] % 2 == 0)
                sums += freqs[0] / 2;
            for (var i=1; i<=k/2 && i != (k-i); ++i)
            {
                if (freqs[i] == freqs[k-i])
                {
                    sums += freqs[i];
                }
            }
            if (k % 2 == 0)
            {
                if (freqs[k / 2] % 2 == 0)
                    sums += freqs[k / 2]/2;
            }

            return sums == arr.Length / 2;
        }
}