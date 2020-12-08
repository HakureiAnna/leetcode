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
class Node {
    public TreeNode node;
    public int pos;
}

public class Solution {
    public int WidthOfBinaryTree(TreeNode root) {
        var processing = new Queue<Node>();
        var maxDist = Int32.MinValue;
        processing.Enqueue(new Node{node = root, pos = 1});            
        
        while (processing.Count > 0) {            
            var size = processing.Count;   
            var left = processing.Peek().pos;
            while (size > 0) {
                var node = processing.Dequeue();
                var right = node.pos;
                if (node.node.left != null)
                {
                    processing.Enqueue(new Node{node = node.node.left, pos = node.pos * 2});
                }
                if (node.node.right != null)
                {
                    processing.Enqueue(new Node{node = node.node.right, pos = node.pos * 2 + 1});
                }
                maxDist = Math.Max(maxDist, right - left + 1);
                size--;
            }
        }
        return maxDist;
    }
}