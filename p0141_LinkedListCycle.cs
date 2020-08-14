/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        var pew = head;
        var pewpew = head;
        while (true) {
            if (pew == null)
                return false;
            pew = pew.next;
            
            pewpew = pewpew.next;
            if (pewpew == null)
                return false;
            pewpew = pewpew.next;
            if (pewpew == null)
                return false;
            
            if (pewpew == pew)
                return true;
        }
    }
}