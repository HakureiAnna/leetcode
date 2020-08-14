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
    public bool IsSymmetric(TreeNode root)
        {
            if (root != null)
                return compare(root.left, root.right);
            return true;
        }

        public bool compare(TreeNode left, TreeNode right)
        {
            if (left == null && right == null)
                return true;
            else if (left != null && right != null)
            {
                if (left.val == right.val)
                    return compare(left.left, right.right) && compare(left.right , right.left);
            }
            return false;
        }
}