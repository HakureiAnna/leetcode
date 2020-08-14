public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        var lut = new Dictionary<int,int>();
        foreach (var num in nums) {
            if (!lut.ContainsKey(num))
                lut[num] = 1;
            else
                lut[num]++;
        }
        var dups = new List<int>();
        foreach (var key in lut.Keys) {
            if (lut[key] > 1)
                dups.Add(key);
        }
        return dups;
    }
}