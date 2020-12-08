public class Solution {
 public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (var i = 0; i < n; ++i)
            {
                nums1[i + m] = nums2[i];
            }
            mergeSort(nums1, 0, m + n - 1);
        }

        void mergeSort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;
                mergeSort(arr, l, m);
                mergeSort(arr, m + 1, r);

                merge(arr, l, m, r);
            }
        }


        void merge(int[] arr, int l, int m, int r)
        {
            int i, j, k;
            int n1 = m - l + 1;
            int n2 = r - m;

            var L = new int[n1];
            var R = new int[n2];
            for (i = 0; i < n1; ++i)
            {
                L[i] = arr[l + i];
            }
            for (j = 0; j < n2; ++j)
            {
                R[j] = arr[m + j + 1];
            }

            i = 0;
            j = 0;
            k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k++] = L[i++];
                }
                else
                {
                    arr[k++] = R[j++];
                }
            }

            while (i < n1)
            {
                arr[k++] = L[i++];
            }
            while (j < n2)
            {
                arr[k++] = R[j++];
            }
        }
    
    
}