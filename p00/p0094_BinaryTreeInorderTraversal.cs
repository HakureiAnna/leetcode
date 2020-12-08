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
    public IList<int> InorderTraversal(TreeNode root) {
        var container = new List<int>();
        
        traverse(root, container);
        
        return container;
    }
    
    void traverse(TreeNode root, IList<int> container) {
        if (root != null) {
            if (root.left != null)
                traverse(root.left, container);
            container.Add(root.val);
            if (root.right != null)
                traverse(root.right, container);
        }
    }
}