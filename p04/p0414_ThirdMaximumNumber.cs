public class Solution {
    public int ThirdMax(int[] nums) {
        var len = nums.Length;
        mergeSort(nums, 0, len-1);
        var max = new int[3];
        var j = 0;
        max[0] = nums[len-1];
        for (var i=nums.Length-2; i >=0; --i) {
            if (max[j] == nums[i])
                continue;
            else {
                max[++j] = nums[i];
            }
            if (j == 2)
                break;
        }
        return j == 2? max[2]: max[0];
    }
    
    public void merge(int[] arr, int l, int m, int r) {
        var n1 = m - l + 1;
        var n2 = r - m;
        
        var i = 0;
        var j = 0;
        var k = 0;
        var L = new int[n1];
        var R = new int[n2];
        
        for (i=0; i<n1; ++i) 
            L[i] = arr[l + i];
        for (i=0; i<n2; ++i)
            R[i] = arr[ m + i + 1];
        
        i = 0;
        j = 0;
        k = l;
        while (i < n1 && j < n2) {
            if (L[i] <= R[j]) {
                arr[k++] = L[i++];
            } else {
                arr[k++] = R[j++];
            }
        }
        
        while (i < n1) {
            arr[k++] = L[i++];
        }
        
        while (j < n2) {
            arr[k++] = R[j++];
        }
    }
    
    public void mergeSort(int[] arr, int l, int r) {
        if (l < r) {
            var m = l + (r - l)/2;
            mergeSort(arr, l, m);
            mergeSort(arr, m+1, r);
            
            merge(arr, l, m, r);
        }
    }
}