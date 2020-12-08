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
    public ListNode ReverseList(ListNode head) {
        if (head == null || head.next==null)
            return head;
        var front = head;
        ListNode next = null;
        ListNode current = head.next;
        ListNode temp;
        while (current != null) {
            next = current.next;
            head.next = next;
            current.next = front;
            front = current;
            current = next;            
        }
        return front;
    }
}