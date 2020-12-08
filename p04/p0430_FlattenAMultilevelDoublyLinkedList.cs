/*
// Definition for a Node.
public class Node {
    public int val;
    public Node prev;
    public Node next;
    public Node child;
}
*/

public class Solution {
    public Node Flatten(Node head) {
        var current = head;
        var nexts = new Stack<Node>();
        
        while (current != null) {
            if (current.child != null) {
                nexts.Push(current.next);
                current.next = current.child;
                current.child.prev = current;
                current.child = null;
            } else if (current.next == null && nexts.Count > 0) {
                current.next = nexts.Pop();
                if (current.next != null)
                    current.next.prev = current;
            }
            current = current.next;
        }
        
        return head;
    }
}