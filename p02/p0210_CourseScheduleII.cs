public class Solution {
 public int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            // create adjacency list and indegree array
            var adjacencyList = new List<int>[numCourses];
            var indegree = new int[numCourses];
            for (var i=0; i<numCourses; ++i)
            {
                adjacencyList[i] = new List<int>();
            }
            foreach (var prereq in prerequisites)
            {
                adjacencyList[prereq[1]].Add(prereq[0]);
                indegree[prereq[0]]++;
            }

            // add indegree=0 to queue
            var toBeProcessed = new Queue<int>();
            for (var i=0; i<indegree.Length; ++i)
            {
                if (indegree[i] == 0)
                    toBeProcessed.Enqueue(i);
            }

            // process queue until empty
            var courseOrder = new int[numCourses];
            var index = 0;
            while (toBeProcessed.Count > 0)
            {
                var currentCourse = toBeProcessed.Dequeue();

                foreach (var subsequentCourse in adjacencyList[currentCourse])
                {
                    indegree[subsequentCourse]--;
                    if (indegree[subsequentCourse] == 0)
                    {
                        toBeProcessed.Enqueue(subsequentCourse);
                    }
                }

                courseOrder[index++] = currentCourse;
            }

            return index == numCourses ? courseOrder : new int[0];
        }
}