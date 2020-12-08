public class Solution {
    public IList<IList<int>> Subsets(int[] nums)
        {
            var result = new List<IList<int>>();
            var set = new LinkedList<int>();
            traverseSubsets(result, nums, 0, set);
            return result;
        }

        void traverseSubsets(IList<IList<int>> result, int[] nums, int index, LinkedList<int> currentSet)
        {
            result.Add(new List<int>(currentSet));
            for (var i=index; i<nums.Length; ++i)
            {
                currentSet.AddLast(nums[i]);
                traverseSubsets(result, nums, i + 1, currentSet);
                currentSet.RemoveLast();
            }            
        }
}