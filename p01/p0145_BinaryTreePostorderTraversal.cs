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
    public IList<int> PostorderTraversal(TreeNode root) {
        var container = new List<int>();
        if (root != null)
            traverse(root, container);
        return container;
    }
    
    void traverse(TreeNode root, IList<int> container) {
        if (root.left != null)
            traverse(root.left, container);
        if (root.right != null)
            traverse(root.right, container);
        container.Add(root.val);
    }
}