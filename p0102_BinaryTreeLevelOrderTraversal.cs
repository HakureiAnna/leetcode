/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        var result = new List<IList<int>>();
        var processingQueue = new Queue<TreeNode>();
        if (root != null)
            processingQueue.Enqueue(root);
        while (processingQueue.Count > 0) {
            var size = processingQueue.Count;
            var list = new List<int>();
            while (size-- > 0) {
                var curr = processingQueue.Dequeue();
                list.Add(curr.val);
                if (curr.left != null)
                    processingQueue.Enqueue(curr.left);
                if (curr.right != null)
                    processingQueue.Enqueue(curr.right);
            }
            result.Add(list);
        }
        return result;
    }
}