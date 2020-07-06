public class Solution {
    public bool IsPathCrossing(string path) {
                    var len = path.Length;
            var i = 0;
            var points = new List<Point>();
            int currX = 0;
            int currY = 0;
            Point point;

            points.Add(new Point { x = 0, y = 0 });
            for (i=0; i<len; ++i)
            {
                switch (path[i])
                {
                    case 'N':
                        currY++;
                        break;
                    case 'S':
                        currY--;
                        break;
                    case 'E':
                        currX++;
                        break;
                    case 'W':
                        currX--;
                        break;
                }
                point = new Point { x = currX, y = currY };
                foreach (var p in points)
                {
                    if (p.x == point.x && p.y == point.y)
                    {
                        return true;
                    }
                }
                points.Add(point);
            }
            return false;
    }
}    
public class Point
    {
        public int x;
        public int y;
    }