public class Solution {
    public int[] SortArrayByParity(int[] A) {
        var len = A.Length;
        var l = 0;
        var r = len - 1;
        while (l < r) {
            if (A[l] % 2 == 1 && A[r] % 2 == 0) {
                var tmp = A[l];
                A[l] = A[r];
                A[r] = tmp;
                l++;
                r--;
            } 
            
            while (l < len && A[l] % 2 == 0) {
                l++;                
            }
            while (r >= 0 && A[r] % 2 == 1) {
                r--;
            }
        }
        return A;
    }
}