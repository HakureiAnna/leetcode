using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[]
            {
                -1, 0, 1, 2, -1, -4
            };

            var prg = new Program();
            foreach (var triplet in prg.ThreeSum(nums))
            {

                Console.WriteLine("{0}, {1}, {2}", triplet[0], triplet[1], triplet[2]);
            }
        }
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var result = new List<IList<int>>();
            Array.Sort(nums);
            var len = nums.Length;

            for (var i = 0; i < len; ++i)
            {
                if (i > 0)
                    while (i < len && nums[i] == nums[i - 1])
                        ++i;
                if (i == len)
                    break;
                var l = i + 1;
                var r = len - 1;
                var v = nums[i];
                while (l < r)
                {
                    var sum = v + nums[l] + nums[r];
                    if (sum == 0)
                    {
                        result.Add(new List<int>()
                        {
                            v,
                            nums[l],
                            nums[r]
                        });
                        l++;
                        r--;
                    }
                    else if (sum < 0)
                    {
                        l++;
                    }
                    else
                    {
                        r--;
                    }

                    if (l > i + 1)
                    {
                        while (l < len && nums[l] == nums[l - 1])
                            ++l;
                    }
                    if (r < len - 1)
                    {
                        while (r > 0 && nums[r] == nums[r + 1])
                            --r;
                    }
                }
            }

            return result;
        }
    }
}