/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode RemoveElements(ListNode head, int val) {
        var current = head;
        ListNode prev = null;
        while (current != null) {
            if (current == head) {
                if (current.val == val) {
                    head = head.next;
                    current = head;
                } else {
                    prev = current;
                    current = current.next;
                }
            } else {
                if (current.val == val) {
                    prev.next = current.next;
                } else {
                    prev = current;
                }
                current = current.next;
            }
        }
        return head;
    }
}