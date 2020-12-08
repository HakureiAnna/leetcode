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
    public int SumRootToLeaf(TreeNode root)
        {
            if (root == null)
                return 0;
            return traverse(root, 0);
        }

        public int traverse(TreeNode node, int val)
        {        
            var sum = 0;
            val <<= 1;
            val |= node.val;
            if (node.left == null && node.right == null)
            {
                return val;
            }
            if (node.left != null)
            {
                sum += traverse(node.left, val);
            }
            if (node.right != null)
            {
                sum += traverse(node.right, val);
            }
            return sum;
        }
}