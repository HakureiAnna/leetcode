public class Solution {
 
        public int[] FindRightInterval(int[][] intervals)
        {
            var len = intervals.Length;
            var map = new Point[len];
            var max = Int32.MinValue;
            var curr = 0;
            for (var i=0; i<len; ++i)
            {
                curr = intervals[i][0];
                map[i] = new Point { start = curr, id = i };
                max = Math.Max(max, curr);
            }
            Array.Sort(map, (a, b) =>
            {
                return a.start - b.start;
            });

            var result = new int[len];
            for (var i=0; i<len; ++i)
            {
                curr = intervals[i][1];
                if (curr > max)
                {
                    result[i] = -1;
                    continue;
                }

                for (var j=0; j<len; ++j)
                {
                    if (curr <= map[j].start)
                    {
                        result[i] = map[j].id;
                        break;
                    }
                }
            }

            return result;
        }
    }

    class Point
    {
        public int start;
        public int id;
    }