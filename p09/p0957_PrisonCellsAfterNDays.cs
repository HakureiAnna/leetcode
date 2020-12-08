public class Solution {
       public int[] PrisonAfterNDays(int[] cells, int N)
        {
            var len = cells.Length;
            int[] otherCell;
            var prisonStates = new HashSet<int>();
            var period = 0;
            var bin = 0;
            var seen = false;

           // print(fromCell, -1);
            for (var day=0; day<N; ++day)
            {
                otherCell = new int[len];
                for (var i=1; i<len-1; ++i)
                {
                    otherCell[i] = (cells[i - 1] == cells[i + 1] ? 1 : 0);
                }
                bin = toBin(otherCell);
                if (prisonStates.Contains(bin))
                {
                    seen = true;
                    break;
                }
                period++;
                prisonStates.Add(bin);
                cells = otherCell;
            }
            if (seen)
            {
                return PrisonAfterNDays(cells, N % period);
            }
            return cells;
        }

        public int toBin(int[] cells)
        {
            var result = 0;
            for (var i=0; i<cells.Length; ++i)
            {
                result <<= 1;
                result |= cells[i];
            }
            return result;
        }
}