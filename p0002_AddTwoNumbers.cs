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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode head = null;
        ListNode current = null;
        ListNode prev = null;
        int carry = 0;
        int result = 0;
        int valL1 = 0;
        int valL2 = 0;
        
        while (l1 != null || l2 != null) {
            valL1 = l1 == null? 0: l1.val;
            valL2 = l2 == null? 0: l2.val;
            result = valL1 + valL2 + carry;
            carry = result / 10;
            result %= 10;
            current = new ListNode(result);
            if (prev != null)
                prev.next = current;
            else {
                head = current;
            }
            prev = current;
            l1 = l1 == null? null: l1.next;
            l2 = l2 == null? null: l2.next;
        }
        if (carry > 0) {
            current = new ListNode(1);
            prev.next = current;
        }
        return head;
    }
}