public class Solution {

        
        public int OrangesRotting(int[][] grid)
        {
            var rottens = new Queue<Orange>();
            var directions = new int[4][]
            {
                new int[] {-1, 0},
                new int[] {1, 0},
                new int[] {0, -1},
                new int[] {0, 1}
            };
            var steps = 0;
            var fresh = 0;

            var h = grid.Length;
            var w = grid[0].Length;
            for (var y=0; y<h; ++y)
            {
                for (var x=0; x<w; ++x)
                {
                    if (grid[y][x] == 2)
                        rottens.Enqueue(new Orange { x = x, y = y });
                    else if (grid[y][x] == 1)
                        fresh++;
                }
            }

            while (rottens.Count > 0 && fresh > 0)
            {
                steps++;
                var size = rottens.Count;
                while (size-- > 0)
                {
                    var rotten = rottens.Dequeue();
                    foreach (var direction in directions)
                    {
                        var x = rotten.x + direction[0];
                        var y = rotten.y + direction[1];

                      
                        if (x < 0 || x >= w || y < 0 || y >= h || grid[y][x] == 2 || grid[y][x] == 0)
                            continue;

                        rottens.Enqueue(new Orange { x = x, y = y });
                        grid[y][x] = 2;
                        fresh--;
                    }
                }
            }
            return fresh == 0 ? steps : -1;
        }


    }

    class Orange
    {
        public int x;
        public int y;
    }