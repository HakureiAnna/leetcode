class Node {
    public int val;
    public Node next;
    public Node prev;
}

public class MyLinkedList {
    Node head;
    Node tail;
    int count;
    
    /** Initialize your data structure here. */
    public MyLinkedList() {
        head = null;
        tail = null;
        count = 0;
    }
    
    /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
    public int Get(int index) {
        if (index < 0 || index >= count)
            return -1;
        else if (index == 0)
            return head.val;
        else if (index == count - 1)
            return tail.val;
        var current = head;
        var i = 0;
        while (current != null) {
            if (i == index)
                return current.val;
            current = current.next;
            ++i;
        }
        return -1;
    }
    
    /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
    public void AddAtHead(int val) {
        if (head == null) {
            head = new Node {val = val};
            tail = head;
        } else {
            var tmp = head;
            head = new Node {val = val, next = tmp};
            tmp.prev = head;
            if (count == 1)
                tail = tmp;
        }
        count++;
    }
    
    /** Append a node of value val to the last element of the linked list. */
    public void AddAtTail(int val) {
        if (count == 0) {
            AddAtHead(val);
            return;
        }
        
        var current = head;
        while (current.next != null)
            current = current.next;
        current.next = new Node{val = val, prev = current};
        tail = current.next;
        count++;
    }
    
    /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
    public void AddAtIndex(int index, int val) {
        if (index == 0) {
            AddAtHead(val);
        } else if (index == count) {
            AddAtTail(val);
        } else {
            var current = head;
            var i = 1;
            while (i != index) {
                current = current.next;
                i++;
            }
            var tmp = current.next;
            current.next = new Node{val = val, next = tmp, prev = current};
            tmp.prev = current.next;
            count++;
        }
    }
    
    /** Delete the index-th node in the linked list, if the index is valid. */
    public void DeleteAtIndex(int index) {
        if (index >= count) {
            return;
        }
        if (index == 0) {
            head = head.next;
            count--;
        } else if (index == count - 1) {
            tail = tail.prev;
            tail.next = null;
            count--;
        } else {
            var current = head;
            var i = 0;
            while (i != index) {
                current = current.next;
                ++i;
            }
            var next = current.next;
            var prev = current.prev;
            prev.next = next;
            if (next != null)
                next.prev = prev;
            count--;
        }
    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */