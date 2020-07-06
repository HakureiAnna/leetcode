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
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
        var processingQueue = new Queue<TreeNode>();
        var result = new List<IList<int>>();
        
        if (root == null) {
            return result;
        }
        
        processingQueue.Enqueue(root);
        while (processingQueue.Count > 0) {
            var size = processingQueue.Count;
            
            var currentLevel = new List<int>();
            while (size-- > 0) {
                var currentNode = processingQueue.Dequeue();
                currentLevel.Add(currentNode.val);
                if (currentNode.left != null) {
                    processingQueue.Enqueue(currentNode.left);                    
                }
                if (currentNode.right != null) {
                    processingQueue.Enqueue(currentNode.right);
                }
            }
            result.Add(currentLevel);
        }
        
        result.Reverse();
        
        return result;
    }
}