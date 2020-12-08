public class Solution {
    public int[] SortedSquares(int[] A) {
        var len = A.Length;
        for (var i=0; i<len-1; ++i) {
            //Console.WriteLine("current:{0}", A[i]);
            A[i] = Math.Abs(A[i]);
            var moved = false;
            for (var j=i+1; j<len; ++j) {
                if (A[j-1] > A[j]) {  
                    //Console.WriteLine("Swapping {0} <-> {1}", A[j-1], A[j]);
                    var tmp = A[j-1];
                    A[j-1] = A[j];
                    A[j] = tmp;
                    moved = true;
                } else {
                    break;
                }
            }
            if (moved)
                i--;
        }
        for (var i=0; i<len; ++i) {
            A[i] = A[i] * A[i];
        }
        return A;
    }
}