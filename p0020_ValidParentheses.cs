public class Solution {  public bool IsValid(string s)
        {
            var lut = new Dictionary<char, char>();
            lut['('] = ')';
            lut['{'] = '}';
            lut['['] = ']';

            var expected = new Stack<char>();
            for (var i=0; i<s.Length; ++i)
            {
                if (lut.ContainsKey(s[i]))
                {
                    expected.Push(lut[s[i]]);
                }
                else
                {
                    if (expected.Count > 0)
                    {
                        var current = expected.Pop();
                        if (current != s[i])
                            return false;
                    }
                    else
                        return false;
                }
            }
            return expected.Count == 0;
        }
}