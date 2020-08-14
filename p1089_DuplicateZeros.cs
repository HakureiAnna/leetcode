public class Solution {
    public void DuplicateZeros(int[] arr) {
        for (var i=0; i<arr.Length-1; ++i) {
            if (arr[i] == 0) {
                for (var j = arr.Length-2; j > i; --j) {
                    arr[j+1] = arr[j];
                }
                arr[++i] = 0;
            }
        }
    }
}