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

        public IList<int> GetAllElements(TreeNode root1, TreeNode root2)
        {

            var l1 = new LinkedList<int>();
            if (root1 != null)
                traverse(l1, root1);
            var l2 = new LinkedList<int>();
            if (root2 != null)
                traverse(l2, root2);

            var c1 = l1.First;
            var c2 = l2.First;
            var result = new List<int>();
            while (c1 != null || c2 != null)
            {
                if (c1 != null && c2 != null)
                {
                    if (c1.Value < c2.Value)
                    {
                        result.Add(c1.Value);
                        c1 = c1.Next;
                    }
                    else
                    {
                        result.Add(c2.Value);
                        c2 = c2.Next;
                    }
                } else if (c1 != null)
                {
                    result.Add(c1.Value);
                    c1 = c1.Next;
                } else
                {
                    result.Add(c2.Value);
                    c2 = c2.Next;
                }
            }
            return result;
        }

        public void traverse(LinkedList<int> list, TreeNode root)
        {
            if (root.left != null)
                traverse(list, root.left);
            list.AddLast(root.val);
            if (root.right != null)
                traverse(list, root.right);
        }
}