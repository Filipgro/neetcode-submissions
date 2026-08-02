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
    public bool HasCycle(ListNode head) {
        HashSet<ListNode> visited=new HashSet<ListNode>();
        ListNode curr = head;
        while(curr!=null){
            if(visited.Contains(curr)){
                return true;
            }
            visited.Add(curr);
            curr=curr.next;
        }
        return false;
    }
}
