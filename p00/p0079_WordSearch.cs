public class Solution {
 public bool Exist(char[][] board, string word)
        {
            var yLen = board.Length;
            var xLen = board[0].Length;

            for (var y=0; y<yLen; ++y)
            {
                for (var x=0; x<xLen; ++x)
                {
                    if (dfs(board, word, x, y, 0))
                        return true;
                }
            }
            return false;
        }

        public bool dfs(char[][] board, string word, int x, int y, int i)
        {
            if (i == word.Length - 1)
            {
                return board[y][x] == word[i];
            }
            var result = false;
            if (board[y][x] == word[i])
            {
                var tmp = board[y][x];
                board[y][x] = '0';
                //Console.WriteLine("{0}", board[y][x]);
                // left
                if (x - 1 >= 0)
                {
                    result = dfs(board, word, x - 1, y, i + 1);
                }
                if (result)
                    return result;
                // up
                if (y - 1 >= 0)
                {
                    result = dfs(board, word, x, y - 1, i + 1);
                }
                if (result)
                    return result;
                // right
                if (x + 1 < board[0].Length)
                {
                    result = dfs(board, word, x + 1, y, i + 1);
                }
                if (result)
                    return result;
                // down
                if (y + 1 < board.Length)
                {
                    result = dfs(board, word, x, y + 1, i + 1);
                }
                board[y][x] = tmp;
            }

            return result;
        }
}