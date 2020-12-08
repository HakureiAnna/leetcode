/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {        
        public Node CopyRandomList(Node head)
        {
            var lut = new Dictionary<Node, int>();
            var current = head;
            var i = 0;
            while (current != null)
            {
                lut[current] = i++;
                current = current.next;
            }
            if (i == 0)
                return null;
            var len = i;
            var refs = new int[len];
            current = head;
            i = 0;
            while (current != null)
            {
                refs[i++] = current.random == null ? -1 : lut[current.random];
                current = current.next;
            }

            Node newHead = null;
            Node newCurrent = null;
            var newLut = new Node[len];
            i = 0;
            current = head;
            while (current != null)
            {               
                if (newHead == null)
                {
                    newHead = new Node(current.val);
                    newCurrent = newHead;
                    newLut[i++] = newHead;
                } else
                {
                    newCurrent.next = new Node(current.val);
                    newCurrent = newCurrent.next;
                    newLut[i++] = newCurrent;
                }
                current = current.next;
            }

            newCurrent = newHead;
            for (i=0; i<len; ++i)
            {
                if (refs[i] != -1)
                {
                    newCurrent.random = newLut[refs[i]];
                }
                newCurrent = newCurrent.next;
            }

            return newHead;
        }
}