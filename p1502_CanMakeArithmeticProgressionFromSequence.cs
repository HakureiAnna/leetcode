public class Solution {
        public bool CanMakeArithmeticProgression(int[] arr)
        {
            Array.Sort(arr);
            if (arr.Length < 2)
                return false;
            var diff = arr[1] - arr[0];
            for (var i=2; i<arr.Length; ++i)
            {
                if (arr[i] - arr[i - 1] != diff)
                    return false;
            }
            return true;
        }
}