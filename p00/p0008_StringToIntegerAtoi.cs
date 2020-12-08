public class Solution {
    public int MyAtoi(string str) {
        str = str.Trim();
        if (str.Length == 0)
            return 0;
        bool isNegative = (str[0] == '-'? true: false);
        if (str[0] == '-' || str[0] == '+')
            str = str.Substring(1);
        var endId = str.Length;
        for (var i=0; i<str.Length; ++i) {
            if (str[i] < '0' || str[i] > '9') {
                endId = i;
                break;
            }
        }
        str = str.Substring(0, endId);
        if (str.Length == 0)
            return 0;
        int result;
        if (!Int32.TryParse(str, out result)) {
            if (isNegative)
                result = Int32.MinValue;
            else
                result = Int32.MaxValue;
        } else {
            result *= (isNegative? -1: 1);
        }
        return result;        
    }
}