public class Solution {
    public int[] ReplaceElements(int[] arr) {
        var len = arr.Length;
        var limit = len-1;
        for (var i=0; i<limit; ++i) {
            var max = Int32.MinValue;
            for (var j=i+1; j<len; ++j) {
                if (max < arr[j])
                    max = arr[j];
            }
            arr[i] = max;
        }   
        arr[limit] = -1;
        return arr;
    }
}