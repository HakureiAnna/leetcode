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
public class Solution {  public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null) {
                return head;
            } 
            var count = 0;
            var current = head;
            while (current != null)
            {
                count++;
                current = current.next;
            }
            if (count == 1)
                return head;
    
            k %= count;
            if (k == 0)
                return head;
            var newHeadId = count - k;
            var prevId = newHeadId - 1;    
            ListNode prev = null;
            ListNode newHead = null;
            ListNode last = null;

            current = head;
            var i = 0;
            while (current != null)
            {
                if (i == prevId)
                {
                    prev = current;
                } else if (i == newHeadId)
                {
                    newHead = current;
                } 
                
                if (i == count - 1) {
                    last = current;
                }
                i++;
                current = current.next;
            }

            prev.next = null;
            last.next = head;
            return newHead;
        }
}