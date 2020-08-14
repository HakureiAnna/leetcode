/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
  
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            ListNode ptrA = headA;
            ListNode ptrB = headB;
            if (ptrA == null || ptrB == null)
                return null;

           while (ptrA != ptrB) {
               ptrA = ptrA.next;
               ptrB = ptrB.next;
               
               if (ptrA == ptrB)
                   return ptrA;
               
               if (ptrA == null)
                   ptrA = headA;
               if (ptrB == null)
                   ptrB = headB;
           }
           return ptrA;
        }
}