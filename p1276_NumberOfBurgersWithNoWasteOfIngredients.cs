using System.Collections.Generic;

public class Solution {

    public IList<int> NumOfBurgers(int tomatoSlices, int cheeseSlices) {
        int small = (4 * cheeseSlices - tomatoSlices);
        int large = 0;
        var result = new List<int>();
        small /= 2;
        large = cheeseSlices - small;
        if (small < 0 || large < 0)
            return result;
        if (tomatoSlices - (large * 4 + small * 2) != 0) {
            return result;
        }
        if (cheeseSlices - large - small != 0)
            return result;
        result.Add(large);
        result.Add(small);
        return result;
    }
}