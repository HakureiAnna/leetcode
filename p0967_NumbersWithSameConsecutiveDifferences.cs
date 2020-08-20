public class Solution {

        public int[] NumsSameConsecDiff(int N, int K)
        {
            if (N == 1)
                return new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var container = new List<int>();
            recurse(container, 0, 0, -1, N, K);
            return container.ToArray();
        }

         public void recurse(IList<int> container, int x, int id, int prev, int N, int K)
        {
            if (id == N)
            {
                container.Add(x);
                return;
            }
            if (prev != -1)
            {
                for (var i = 0; i < 10; ++i)
                {
                    if (Math.Abs(prev - i) == K)
                        recurse(container, x * 10 + i, id + 1, i, N, K);
                }
            } 
            else
            {
                for (var i = 1; i < 10; ++i)
                    recurse(container, i, 1, i, N, K);
            }
        }
}