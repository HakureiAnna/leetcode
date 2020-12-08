public class Solution {
    public int[] DistributeCandies(int candies, int num_people) {
        var distribution = new int[num_people];
        var give = 1;
        var i = 0;
        while (candies > 0) {
            distribution[i++] += give < candies? give: candies;
            candies -= give;
            give++;
            if (i == num_people)
                i = 0;
        }
        return distribution;
    }
}