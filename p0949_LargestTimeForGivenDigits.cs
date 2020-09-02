public class Solution { 
        int max = -1;
        public string LargestTimeFromDigits(int[] A)
        {
            var digits = new List<int>(A);
            traverse(digits, new List<int>());
            if (max < 0)
                return "";
            var hr = max / 100;
            var min = max % 100;
            var result = new StringBuilder();
            if (hr < 10)
                result.Append("0");
            result.Append(hr);
            result.Append(":");
            if (min < 10)
                result.Append("0");
            result.Append(min);
            return result.ToString();
        }

        public void traverse(IList<int> digits, IList<int> time)
        {
            var set = false;
            for (var i=0; i<digits.Count; ++i)
            {
                if (digits[i] == -1)
                    continue;
                set = true;
                var current = new List<int>(digits);
                var timeNew = new List<int>(time);
                timeNew.Add(current[i]);
                current[i] = -1;
                traverse(current, timeNew);
            }
            if (!set)
            {
                if (time[0] > 2)
                    return;
                if (time[0] == 2 && time[1] > 3)
                    return;
                if (time[2] > 5)
                    return;
                var t = time[0] * 1000 + time[1] * 100 + time[2] * 10 + time[3];
                if (t > max)
                {
                    max = t;
                }
            }
        }
}