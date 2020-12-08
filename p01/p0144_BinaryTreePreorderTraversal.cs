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
    public IList<int> PreorderTraversal(TreeNode root) {
        var container = new List<int>();
        
        traverse(container, root);
        
        return container;
    }
    
    private void traverse(IList<int> container, TreeNode root) {
        if (root == null)
            return;
        
        container.Add(root.val);
        traverse(container, root.left);
        traverse(container, root.right);
    }
}