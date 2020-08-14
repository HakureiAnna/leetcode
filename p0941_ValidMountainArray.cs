public class Solution {
    public bool ValidMountainArray(int[] A) {
        var len = A.Length;
        if (len < 3)
            return false;
        
        var maxId = -1;
        var max = Int32.MinValue;
        for (var i=0; i<len; ++i) {
            if (A[i] > max) {
                max = A[i];
                maxId = i;
            }
        }
        if (maxId < 0 || maxId == 0 || maxId == len -1)
            return false;
        for (var i=maxId; i>0; --i) {
            if (A[i] <= A[i-1]) {
                return false;
            }
        }
        for (var i=maxId; i <len-1; ++i) {
            if (A[i] <= A[i+1])
                return false;
        }
        return true;
    }
}