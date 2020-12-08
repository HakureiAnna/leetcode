public class Solution {
    public int[] PlusOne(int[] digits) {
        var len = digits.Length;
        if (len == 0) {
            return digits;
        }
        var sum = digits[len - 1] + 1;
        digits[len - 1] = sum % 10;
        var carry = sum / 10;
        if (len > 1) {
            for (var i=len-2; i>=0; --i) {
                sum = digits[i] + carry;
                digits[i] = sum % 10;;
                carry = sum / 10;
                if (carry == 0)
                    break;
            }
        }
        if (carry == 1) {
            var result = new int[len + 1];
            for (var i=0; i < len; ++i) {
                result[i+1] = digits[i];
            }
            result[0] = carry;
            return result;
        }
        return digits;
    }
}