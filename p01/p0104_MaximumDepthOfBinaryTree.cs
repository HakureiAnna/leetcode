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
        public int MaxDepth(TreeNode root)
        {
            return traverse(root, 0);
        }
        public int traverse(TreeNode root, int depth)
        {
            if (root == null)
                return 0;
            var leftMax = traverse(root.left, depth + 1);
            var rightMax = traverse(root.right, depth + 1);
            return Math.Max(leftMax, rightMax) + 1;
        }
}