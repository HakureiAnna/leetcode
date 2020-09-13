public class Solution {        
    public int LargestOverlap(int[][] A, int[][] B)
    {
        var overlapArea = 0;
        for (var i = -A.Length + 1; i < A.Length; ++i)
            for (var j = -A[0].Length + 1; j < A[0].Length; ++j)
                overlapArea = Math.Max(overlapArea, overlap(A, B, i, j));

        return overlapArea;
    }

    public int overlap(int[][] A, int[][] B, int r, int c)
    {
        var overlapped = 0;
        for (var i=0; i<A.Length; ++i) 
            for (var j=0; j<A[0].Length; ++j)
            {
                if (i + r < 0 || i + r >= A.Length || j + c < 0 || j + c >= A[0].Length || A[i][j] + B[i + r][j + c] != 2)
                    continue;
                overlapped++;
            }
        return overlapped;
    }
}