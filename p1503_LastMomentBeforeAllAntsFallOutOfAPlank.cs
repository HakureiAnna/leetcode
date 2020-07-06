public class Solution {
    public int GetLastMoment(int n, int[] left, int[] right)
    { 
        int max = 0;
        foreach (var ant in left) {
            if (ant > max ) {
                max = ant;
            }
        }
        int min = n;
        foreach (var ant in right) {
            if (ant < min) {
                min = ant;
            }
        }
        min = n - min;
        return Math.Max(max, min);
    }
    
}