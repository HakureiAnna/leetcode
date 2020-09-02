/**
 * The Rand7() API is already defined in the parent class SolBase.
 * public int Rand7();
 * @return a random integer in the range 1 to 7
 */
public class Solution : SolBase {
    public int Rand10() {
        int x = Rand7(), y = 7;
        while (x > 5) {
            y = x - 5;
            x = Rand7();
        }
        while (y == 7)
            y = Rand7();
        return (y % 2 == 1? 5: 0) + x;
    }
}