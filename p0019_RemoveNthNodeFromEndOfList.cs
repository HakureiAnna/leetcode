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
    public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var count = 0;
            var current = head;
            ListNode prev = head;
        
            while (current != null)
            {
                count++;
                if (count > n + 1)
                    prev = prev.next;
                current = current.next;
            }
            if (count == 1)
                return null;
            else if (count == 2)
                if (n == 1) {
                    head.next = null;
                    return head;
                } else 
                    return head.next;
                    
            if (head == prev && n == count)
                return prev.next;
        
            if (prev.next != null)
                prev.next = prev.next.next;
            else
                prev.next = null;
        
            return head;
        }
}