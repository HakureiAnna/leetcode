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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
    {
        var toProcess = new Queue<TreeNode>();
        var ltr = false;
        var container = new List<IList<int>>();

        if (root == null)
            return container;

        toProcess.Enqueue(root);
        var rootList = new List<int>();
        rootList.Add(root.val);
        container.Add(rootList);

        while (toProcess.Count > 0)
        {
            var size = toProcess.Count;
            var list = new List<int>();
            while (size-- > 0)
            {
                var node = toProcess.Dequeue();

                TreeNode left = node.left;
                TreeNode right = node.right;
                if (left != null)
                {
                    list.Add(left.val);
                    toProcess.Enqueue(left);
                }
                if (right != null)
                {
                    list.Add(right.val);
                    toProcess.Enqueue(right);
                }
            }
            if (list.Count > 0)
            {

                if (!ltr)
                    list.Reverse();
                container.Add(list);
            }
            ltr = !ltr;
        }

        return container;
    }
}