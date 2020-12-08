public class Solution {
        public int IslandPerimeter(int[][] grid)
        {
            var rows = grid.Length;
            if (rows == 0)
                return 0;
            var cols = grid[0].Length;
            var perimeter = 0;
            for (var i=0; i<rows; ++i)
            {
                for (var j=0; j<cols; ++j)
                {
                    // occupied cell
                    if (grid[i][j] > 0)
                    {
                        if (rows == 1) 
                        {
                            perimeter++;
                        }
                        if (cols == 1)
                        {
                            perimeter++;
                        }
                        if (i == 0)
                        {
                            perimeter++;
                            if (i + 1 < rows && grid[i + 1][j] == 0)
                            {
                                perimeter++;
                            }
                        }
                        else if (i == rows - 1)
                        {
                            perimeter++;
                            if (grid[i - 1][j] == 0)
                            {
                                perimeter++;
                            }
                        }
                        else
                        {
                            if (grid[i - 1][j] == 0)
                            {
                                perimeter++;
                            }
                            if (grid[i + 1][j] == 0)
                            {
                                perimeter++;
                            }
                        }

                        if (j == 0)
                        {
                            perimeter++; 
                            if (j + 1 < cols && grid[i][j + 1] == 0)
                            {
                                perimeter++;
                            }
                        }
                        else if (j == cols - 1)
                        {
                            perimeter++;
                            if (grid[i][j - 1] == 0)
                            {
                                perimeter++;
                            }
                        }
                        else
                        {
                            if (grid[i][j - 1] == 0)
                            {
                                perimeter++;
                            }
                            if (grid[i][j + 1] == 0)
                                perimeter++;
                        }
                    }
                }
            }
            return perimeter;
        }
}