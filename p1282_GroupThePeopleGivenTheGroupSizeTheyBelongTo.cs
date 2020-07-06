public class Solution {
    public IList<IList<int>> GroupThePeople(int[] groupSizes) {
        var processing = new Dictionary<int, List<int>>();
        for (int i=0; i<groupSizes.Length; ++i) {
            if (processing.ContainsKey(groupSizes[i]))
                processing[groupSizes[i]].Add(i);
            else {
                processing[groupSizes[i]] = new List<int>();
                processing[groupSizes[i]].Add(i);
            }
        }
        var result = new List<IList<int>>();
        foreach (var groupSize in processing.Keys) {
            var current = new List<int>();
            foreach (var id in processing[groupSize])
                if (current.Count < groupSize-1) {
                    current.Add(id);
                } else {
                    current.Add(id);
                    result.Add(current);
                    current = new List<int>();
                }
        }
        return result;
    }
}