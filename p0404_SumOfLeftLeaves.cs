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
        public int SumOfLeftLeaves(TreeNode root)
        {
            if (root == null)
                return 0;
            return traverse(root, false);
        }

        public int traverse(TreeNode node, bool parentLeft)
        {
            if (node.left == null && node.right == null)
                return parentLeft ? node.val : 0;
            var sum = 0;
            if (node.left != null)
                sum = traverse(node.left, true);
            if (node.right != null)
                sum += traverse(node.right, false);
            return sum;
        }
}