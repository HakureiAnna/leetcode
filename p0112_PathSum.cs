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
        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root != null)
                return traverse(root, sum, 0);
            return false;
        }
      public bool traverse(TreeNode root, int sum, int total)
        {
            if (root.left == null && root.right == null)
                return total + root.val == sum;
            var result = false;
            if (root.left != null)
                result |= traverse(root.left, sum, total + root.val);
            if (root.right != null)
                result |= traverse(root.right, sum, total + root.val);
            return result;
        }
}