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
    public ListNode MiddleNode(ListNode head) {
        int step = 0;
        ListNode node = head;
        while(node != null)
        {
            step += 1;
            node = node.next;
        }
        int center = 0;
        if(step % 2 == 1)
        {
            step += 1;
            center = step / 2;
        }
        else
        {
            center = (step / 2) + 1;
        }
        
        node = head;
        for(var i = 0; i<center-1; i++)
        {
            node = node.next;
        }

        return node;
    }
}