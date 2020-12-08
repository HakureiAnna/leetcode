public class Solution {
 public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
        {
            var result = new List<IList<int>>();
            dfs(graph, 0, graph.Length - 1, result, new List<int>());
            return result;
        }

        void dfs(int[][] graph, int src, int dest, IList<IList<int>> result, IList<int> path)
        {
            path.Add(src);
            if (src == dest)
                result.Add(path);

            foreach (var dst in graph[src])
            {
                var newPath = new List<int>(path);
                dfs(graph, dst, dest, result, newPath);
            }
        }
}