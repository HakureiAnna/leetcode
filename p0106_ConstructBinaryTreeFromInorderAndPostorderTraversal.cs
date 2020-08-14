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
    public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            var rootPos = postorder.Length - 1;
            return Build(inorder, postorder, ref rootPos, 0, inorder.Length - 1);
        }
        public TreeNode Build(int[] inorder, int[] postorder, ref int rootPos,　
            int inStart, int inEnd)
        {
            if (inStart > inEnd)
                return null;
            var node = new TreeNode { val = postorder[rootPos--] };
            if (inStart == inEnd)
                return node;

            var i = inStart;
            for (; i <= inEnd; ++i)
            {
                if (inorder[i] == node.val)
                {
                    break;
                }
            }

            node.right = Build(inorder, postorder, ref rootPos, i + 1, inEnd);
            node.left = Build(inorder, postorder, ref rootPos, inStart, i - 1);

            return node;
        }
}