public class Solution {
   
        IList<int>[] adjacencyList;
        int[] counts;
        String labels;
    
        public int[] CountSubTrees(int n, int[][] edges, string labels)
        {
            // initialize adjacency list
            adjacencyList = new IList<int>[n];            
            counts = new int[n];
            this.labels = labels;

            for (var i = 0; i < n; ++i)
                adjacencyList[i] = new List<int>();
            foreach (var edge in edges)
            {
                adjacencyList[edge[0]].Add(edge[1]);
                adjacencyList[edge[1]].Add(edge[0]);
            }

            visitKids(0, -1);

            return counts;
        }

        int[] visitKids(int node, int parent)
        {
            var counts = new int[26];
            var label = labels[node];
            counts[label - 'a']++;

            foreach (var adjNode in adjacencyList[node])
            {
                if (adjNode != parent)
                {
                    var counts2 = visitKids(adjNode, node);
                    for (var i=0; i<26; ++i)
                    {
                        counts[i] += counts2[i];
                    }
                }
            }

            this.counts[node] = counts[label - 'a'];
            return counts;
        }
}