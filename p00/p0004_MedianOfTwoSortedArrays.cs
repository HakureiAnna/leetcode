public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
            var list = new List<int>();
            list.AddRange(nums1);
            list.AddRange(nums2);
            list.Sort((a, b) =>
            {
                return a - b;
            });
            int len = list.Count;
            bool isEven = len % 2 == 0;
            int mid = len / 2;
            double median = list[mid];
            if (isEven)
            {
                median += list[mid - 1];
                median /= 2;
            }
            return median;
    }
}