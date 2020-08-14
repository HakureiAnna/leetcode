public class Solution {
        public string MinInteger(string num, int k)
        {
            var arr = num.ToCharArray();
            swap(arr, 0, k);
            return new string(arr);
        }

        public void swap(char[] arr, int startIndex, int k)
        {
            if (k == 0 || startIndex == arr.Length) return;
            var min = arr[startIndex];
            var minId = startIndex;
            for (var i=startIndex+1; i<Math.Min(startIndex + k + 1, arr.Length); ++i)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    minId = i;
                }
            }
            char tmp = min;
            for (var i=minId; i > startIndex; --i)
            {
                arr[i] = arr[i - 1];
            }
            arr[startIndex] = tmp;
            swap(arr, startIndex + 1, k - (minId - startIndex));
        }
}