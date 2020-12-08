using System.Text.RegularExpressions;

public class Solution {      

        public bool IsMatch(string s, string p)
        {
            var sLen = s.Length;
            var pLen = p.Length;
            var matrix = new bool[sLen + 1, pLen+1];
            matrix[0,0] = true;
            for (var i=1; i<=pLen; ++i)
            {
                if (p[i - 1] == '*')
                {
                    matrix[0,i] = matrix[0,i - 2];
                }
            }

            for (var i = 1; i <= sLen; ++i)
            {
                for (var j = 1; j <= pLen; ++j)
                {
                    if (p[j - 1] == '*')
                    {
                        matrix[i,j] = matrix[i, j - 2]; // 0 matches
                        if (!matrix[i,j])
                        {
                            if (p[j-2] == '.' || p[j-2] == s[i-1])
                            {
                                matrix[i,j] = matrix[i - 1, j];
                            }
                        }

                    }
                    else if (p[j - 1] == s[i - 1] || p[j - 1] == '.')
                    {
                        matrix[i, j] = matrix[i - 1, j - 1];
                    }
                    else
                    {
                        matrix[i, j] = false;
                    }
                }
            }

            //print(matrix, s, p);

            return matrix[sLen, pLen];
        }
}
