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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if (p == null && q == null)
            return true;
        else if (p == null)
            return false;
        else if (q == null)
            return false;
        var queue = new Queue<Pair>();
        var count = 1;
        Pair pair;
        queue.Enqueue(new Pair{a = p, b = q});
        while (count > 0) {
            while (count > 0) {
                pair = queue.Dequeue();
                if (pair.a.val != pair.b.val)
                    return false;
                count--;  
                if ((pair.a.left != null && pair.b.left == null) ||
                    (pair.a.left == null && pair.b.left != null))
                    return false;
                if ((pair.a.right != null && pair.b.right == null) ||
                    (pair.a.right == null && pair.b.right !=null))
                    return false;
                if (pair.a.left != null && pair.b.left != null) {
                    queue.Enqueue(new Pair{a = pair.a.left, b= pair.b.left});
                    count++;
                }
                if (pair.a.right != null && pair.b.right != null) {
                    queue.Enqueue(new Pair{a = pair.a.right, b = pair.b.right});
                    count++;
                }
            }
        }
        return true;
    }
    
    class Pair {
        public TreeNode a;
        public TreeNode b;
    }
}