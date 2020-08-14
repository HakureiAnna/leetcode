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
    public int PathSum(TreeNode root, int sum)
    {
        if (root == null)
            return 0;
        return visit(root, sum, new List<int>());
    }

    public int visit(TreeNode node, int sum, IList<int> currSums)
    {
        var sums = new List<int>(currSums);
        var count = 0;
        sums.Add(0);
        for (var i = 0; i < sums.Count; ++i)
        {
            sums[i] += node.val;
            if (sums[i] == sum)
                count++;
        }
        if (node.left != null)
            count += visit(node.left, sum, sums);
        if (node.right != null)
            count += visit(node.right, sum, sums);
        return count;
    }
}