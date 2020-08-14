public class Solution { 
public IList<IList<int>> FourSum(int[] nums, int target)
        {
            var result = new List<IList<int>>();
            var len = nums.Length;
            Array.Sort(nums);
            for (var i=0; i<len-3; ++i)
            {
                if (i != 0 && nums[i] == nums[i - 1])
                    continue;
                for (var j=i+1; j<len-2; ++j)
                {
                    if (j != i + 1 && nums[j] == nums[j - 1])
                        continue;

                    var sum = nums[i] + nums[j];
                    var k = j + 1;
                    var l = len - 1;
                    while (k < l)
                    {
                        var test = sum + nums[k] + nums[l];

                        if (test == target)
                        {
                            var list = new List<int>();
                            list.Add(nums[i]);
                            list.Add(nums[j]);
                            list.Add(nums[k]);
                            list.Add(nums[l]);
                            result.Add(list);
                            k++;
                            --l;
                        } else if (test < target)
                        {
                           k++;
                        } else if (test > target)
                        {
                            l--;
                        }
                        while (k != j + 1 && k < l && nums[k] == nums[k - 1])
                            k++;
                        while (l != len - 1 && l > k && nums[l] == nums[l + 1])
                            l--;
                    }
                }
            }
            return result;
        }
}