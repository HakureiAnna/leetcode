public class Solution {

        public int NumSubmat(int[][] mat)
        {
            var rows = mat.Length;
            var cols = mat[0].Length;

            var countsFromRight = new int[rows, cols];

            var count = 0;
            for (var i = 0; i < rows; ++i)
            {
                count = 0;
                for (var j = cols - 1; j >= 0; --j)
                {
                    if (mat[i][j] == 1)
                    {
                        count++;
                    } else
                    {
                        count = 0;
                    }
                    countsFromRight[i,j] = count;
                }
            }

            count = 0;
            for (var i = 0; i < rows; ++i)
            {
                for (var j = 0; j < cols; ++j)
                {
                    var x = Int32.MaxValue;
                    for (var k=i; k<rows; ++k)
                    {
                        x = Math.Min(x, countsFromRight[k, j]);
                        count += x;
                    }
                }
            }

                return count;
        }
}