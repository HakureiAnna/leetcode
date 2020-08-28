
    class Solution
    {
        Location[] locations;
        int totalArea = 0;
        Random rng;
        int len;
        public Solution(int[][] rects)
        {
            rng = new Random();

            len = rects.Length;
            locations = new Location[len];
            var area = 0;
            for (var i = 0; i < len; ++i)
            {
                area = (rects[i][3] - rects[i][1] + 1) * (rects[i][2] - rects[i][0] + 1);
                totalArea += area;
                locations[i] = new Location {
                    area = totalArea,
                    coords = rects[i]
                };
            }
        }

        public int[] Pick()
        {
            var location = rng.Next(totalArea + 1);
            Location loc = null;
            for (var i=0; i<len; ++i)
            {
                if (location <= locations[i].area)
                {
                    loc = locations[i];
                    break;
                }
            }
            int width = loc.coords[2] - loc.coords[0] + 1;
            int height = loc.coords[3] - loc.coords[1] + 1;
            int x = loc.coords[0] + rng.Next(width);
            int y = loc.coords[1] + rng.Next(height);
            return new int[] { x, y };
        }
    }

    class Location
    {
        public int area;
        public int[] coords;
    }