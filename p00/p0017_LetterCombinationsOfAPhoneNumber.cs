public class Solution {
  public IList<string> LetterCombinations(string digits)
        {
            var retVal = new List<string>();
            var digitsLen = digits.Length;
            if (digitsLen == 0)
                return retVal;
            var possibilities = new char[8][]
            {
                new char[] {'a', 'b', 'c'},
                new char[] {'d', 'e', 'f'},
                new char[] {'g', 'h', 'i'},
                new char[] {'j', 'k', 'l'},
                new char[] {'m', 'n', 'o'},
                new char[] {'p', 'q', 'r', 's'},
                new char[] { 't', 'u', 'v'},
                new char[] {'w', 'x', 'y', 'z'}
            };
            
            var eligibles = new int[digitsLen];
            var resultLen = 1;
            for (var i = 0; i < digitsLen; ++i)
            {
                eligibles[i] = digits[i] - '2';
                resultLen *= possibilities[eligibles[i]].Length;
            }
            var str = new char[digitsLen];
            for (var i=0; i<resultLen; ++i)
            {
                var tmp = i;
                for (var j=digitsLen-1; j>=0; j--)
                {
                    var pos = possibilities[eligibles[j]];
                    var posLen = pos.Length;
                    var k = tmp % posLen;
                    str[j] = pos[k];
                    tmp /= posLen;
                }
                retVal.Add(new string(str));
            }
            
            return retVal;
        }
}