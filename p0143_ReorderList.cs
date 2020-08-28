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
public class Solution {       public void ReorderList(ListNode head)
        {
            if (head == null)
                return;
            var curr = head.next;
            var stack = new Stack<ListNode>();
            var queue = new Queue<ListNode>();
            var count = 0;
            while (curr != null)
            {
                stack.Push(curr);
                queue.Enqueue(curr);
                curr = curr.next;
                count++;
            }
            curr = head;
            var current = true;
            while (count > 0)
            {
                if (current)
                    curr.next = stack.Pop();
                else
                    curr.next = queue.Dequeue();
                curr = curr.next;
                count--;
                current = !current;
            }
            curr.next = null;
        }  
}