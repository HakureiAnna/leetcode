public class Solution {
    
        public IList<int> GetRow(int rowIndex)
        {
            var row = new int[rowIndex + 1];
            row[0] = 1;
            for (var i=1; i<=rowIndex; ++i)
            {
                for (var j = i; j >= 1; --j)
                    row[j] = row[j] + row[j - 1];
            }
            return new List<int>(row);
        }

}