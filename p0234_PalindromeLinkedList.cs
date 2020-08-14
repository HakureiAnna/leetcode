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
    public bool IsPalindrome(ListNode head) {
        var n = 0;
        var current = head;
        while (current != null) {
            n++;
            current = current.next;
        }
        current = head;
        var mid = n / 2;
        var odd = n % 2 == 1;
        ListNode left = null;
        ListNode right = null;
        ListNode next = null;
        var i = 0;
        
        Console.WriteLine("Mid: {0}", mid);
        while (i < n) {
            if (i < mid) {
                if (left == null) {
                    left = current;
                    next = current.next;
                    left.next = null;
                } else {
                    next = current.next;
                    current.next = left;
                    left = current;
                }
                current = next;
            } else if (i == mid) {
                if (odd) {
                    right = current.next;
                } else {
                    right = current;
                }
                break;
            }
            ++i;
        }
                
        current = left;
        var current2 = right;
        i = 0;
        while (i < mid) {
            if (current.val != current2.val)
                return false;
            current = current.next;
            current2 = current2.next;
            ++i;
        }        
        
        return true;
    }
}