public class Solution {   
    public int EraseOverlapIntervals(int[][] intervals)
    {
        Array.Sort(intervals, (a, b) =>
        {
            return a[1] == b[1]? b[0] - a[0] : a[1] - b[1];
        });

        var prevEnd = Int32.MinValue;
        var moves = 0;
        foreach (var combo in intervals) 
        {
            if (prevEnd > combo[0])
                moves++;
            else
                prevEnd = combo[1];
        }
        return moves;
    }
}