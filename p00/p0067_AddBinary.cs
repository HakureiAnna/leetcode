public class Solution {
    public string AddBinary(string a, string b) {
        var result = new Stack<int>();
        var aLen = a.Length;
        var bLen = b.Length;
        var len = Math.Max(aLen,  bLen);
        var aId = aLen-1;
        var bId = bLen-1;
        var sum = 0;
        while (aId >= 0 || bId >=0) {
            if (aId >=0) {
                sum += a[aId] - '0';
                aId--;
            }
            if (bId >=0) {
                sum += b[bId] - '0';
                bId--;
            }
            result.Push(sum % 2);
            sum /= 2;
        }
        if (sum > 0) {
            result.Push(sum);            
        }
        var sb = new StringBuilder();
        while (result.Count > 0)
            sb.Append(result.Pop());
        return sb.ToString();
    }
}