public class Solution {
    
        public bool CheckIfExist(int[] arr)
        {
            Array.Sort(arr);
            var j = 0;
            for (var i = 0; i < arr.Length - 1; ++i)
            {
                j = binSearch(arr, arr[i] * 2);
                if (j >= 0) {
                    if (j != i)
                        return true;
                    else if (i + 1 < arr.Length && arr[i] == 0 && arr[i + 1] == 0)
                        return true;
                }
            }
            return false;
        }

        int binSearch(int[] haystack, int needle)
        {
            var l = 0;
            var r = haystack.Length - 1;
            var m = 0;
            while (l <= r)
            {
                m = l + (r - l) / 2;
                if (needle < haystack[m])
                {
                    r = m - 1;
                }
                else if (needle > haystack[m])
                {
                    l = m + 1;
                }
                else
                {
                    return m;
                }
            }
            return -1;
        }
}