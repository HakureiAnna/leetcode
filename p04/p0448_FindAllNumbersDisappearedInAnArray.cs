public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        var len = nums.Length;
        var freq = new int[len];
        var result = new List<int>();
        foreach (var x in nums) 
            freq[x-1]++;
        for (var i=0; i<len; ++i)
            if (freq[i] == 0)
                result.Add(i+1);
        return result;
    }
}