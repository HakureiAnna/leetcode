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

        IDictionary<int, List<Entry>> lut;

        public IList<IList<int>> VerticalTraversal(TreeNode root)
        {
            lut = new SortedDictionary<int, List<Entry>>();
            traverse(root, 0, 0);
            var result = new List<IList<int>>();
            foreach (var key in lut.Keys)
            {
                lut[key].Sort((e1, e2) =>
                {
                    if (e1.y == e2.y)
                        return e1.val - e2.val;
                    else
                        return e2.y - e1.y;
                });
                var entry = new List<int>();
                foreach (var e in lut[key])
                {
                    entry.Add(e.val);
                }
                result.Add(entry);
            }
            return result;
        }

        public void traverse(TreeNode current, int x, int y)
        {
            if (!lut.ContainsKey(x))
            {
                lut[x] = new List<Entry>();
            }
            lut[x].Add(new Entry { y = y, val = current.val });
            if (current.left != null)
                traverse(current.left, x - 1, y - 1);
            if (current.right != null)
                traverse(current.right, x + 1, y - 1);
        }

    }

    class Entry
    {
        public int y;
        public int val;        
    }