public class Solution {
    public double AngleClock(int hour, int minutes) {
        if (hour == 12)
            hour = 0;
        double degreeHours = (hour + (double)minutes/60) * 30;  
        double degreeMinutes = (double)minutes * 6;
        var result = degreeMinutes > degreeHours? degreeMinutes - degreeHours: degreeHours - degreeMinutes;
        if (result > 180)
            result = 360 - result;
        return result;
    }
}