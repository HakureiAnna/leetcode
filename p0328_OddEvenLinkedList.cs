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
    public ListNode OddEvenList(ListNode head) {
        ListNode oddHead = null;
        ListNode evenHead = null;
        ListNode oddCurrent = null;
        ListNode evenCurrent = null;
        var i = 0;
        var current = head;
        while (current != null) {
            if (i % 2 == 0) {
                if (oddHead != null) {
                    oddCurrent.next = current;
                    oddCurrent = current;
                } else {
                    oddHead = current;
                    oddCurrent = oddHead;
                }
            } else {
                if (evenHead != null) {
                    evenCurrent.next = current;
                    evenCurrent = current;
                } else {
                    evenHead = current;
                    evenCurrent = evenHead;
                }
            }
            ++i;
            current = current.next;
        }
        if (oddCurrent != null)
            oddCurrent.next = evenHead;
        if (evenCurrent != null)
            evenCurrent.next = null;
        return oddHead;        
    }
}