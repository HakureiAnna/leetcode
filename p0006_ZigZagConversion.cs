public class Solution {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1)
                return s;
            int sLen = s.Length;
            int interval = numRows - 1;
            int rowLen =(int)((double)sLen / interval + 0.5);
            var matrix = new List<StringBuilder>();
            for (var i = 0; i < numRows; ++i)
                matrix.Add(new StringBuilder());
            var id = 0;
            var x = 0;
            var y = 0;
            while (id < sLen)
            {
                matrix[y].Append(s[id]);
                if (x % interval == 0)
                {
                    y++;
                    if (y == numRows)
                    {
                        y-=2;
                        x++;
                    }

                } else
                {
                    x++;
                    y--;
                }
                id++;
            }
            var sb = new StringBuilder();
            matrix.ForEach(row =>
            {
                sb.Append(row);
            });
            return sb.ToString();
        }
}