public class Solution {
    public int HeightChecker(int[] heights) {
        var len = heights.Length;
        var sorted = new int[len];
        for (var i=0; i<len; ++i) {
            sorted[i] = heights[i];
        }
        mergeSort(sorted, 0, len-1);
        var count = 0;
        for (var i=0; i<len; ++i) {
            if (heights[i] != sorted[i])
                count++;
        }
        return count;
    }
    void merge(int[] arr, int l, int m, int r) {
        var n1 = m - l + 1;
        var n2 = r - m;
        var i = 0;
        var j = 0;
        var k = 0;
        var L = new int[n1];
        var R = new int[n2];
        
        for (i=0; i<n1; ++i)
            L[i] = arr[l + i];
        for (j=0; j<n2; ++j) {
            R[j] = arr[m + j + 1];
        }
        
        i = 0;
        j = 0;
        k = l;
        while (i < n1 && j < n2) {
            if (L[i] <= R[j]) {
                arr[k] = L[i++];
            } else {
                arr[k] = R[j++];
            }
            ++k;
        }
        
        while (i < n1) {
            arr[k++] = L[i++];
        }
        while (j < n2) {
            arr[k++] = R[j++];
        }
    }
    
    void mergeSort(int[] arr, int l, int r) {
        if (l < r) {
            var m = l + (r - l)/2;
            mergeSort(arr, l, m);
            mergeSort(arr, m+1, r);
            
            merge(arr, l, m, r);
        }
    }
}