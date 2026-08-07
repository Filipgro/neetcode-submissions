/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        if(head==null){
            return null;
        }
       Dictionary<Node, Node> oldToNew = new Dictionary<Node, Node>();
        Node curr=head;
        while(curr!=null){
            Node copy = new Node(curr.val);
            oldToNew[curr]=copy;
            curr=curr.next;
        }

        curr = head;
        while (curr != null)
        {
            Node copy = oldToNew[curr];
            copy.next = curr.next == null ? null : oldToNew[curr.next];
            copy.random = curr.random == null ? null : oldToNew[curr.random];
            curr = curr.next;
        }
        return oldToNew[head];
    }
}
