public class Solution {

        public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
        {
            var len = nums.Length;
            var numbers = new Pair[len];
            for (var i=0; i<len; ++i)
            {
                numbers[i] = new Pair { num = nums[i], i = i };
            }
            Array.Sort(numbers, (a, b) =>
            {
                if (a.num < b.num)
                    return -1;
                else if (a.num > b.num)
                    return 1;
                else
                    return 0;
            });
            foreach (var n in numbers)
                Console.WriteLine("{0}: {1}", n.num, n.i);
            var p1 = 0;
            var p2 = 1;
            while (p2 < len)
            {
                var d1 = numbers[p1].num;
                var d2 = numbers[p2].num;
                var diff = d2 - d1;
                if (diff <= t && Math.Abs(numbers[p2].i - numbers[p1].i) <= k)
                {
                    Console.WriteLine("{0} <= {1}", d2-d1, t);
                    Console.WriteLine("{0} <= {1}", Math.Abs(numbers[p2].i - numbers[p1].i), k);
                    Console.WriteLine("{0}: {1}, {2}: {3}", d1, numbers[p1].i, d2, numbers[p2].i);
                    return true;
                }
                if (Math.Abs(numbers[p2].i - numbers[p1].i) > k)
                    p2++;
                if (diff > t)
                    p1++;
                if (p1 == p2)
                    p2++;
            }
            return false;
        }


    }

    class Pair
    {
        public long num;
        public int i;
    }
