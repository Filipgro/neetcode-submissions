/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        Dictionary<Node,Node> clone = new Dictionary<Node,Node>();
        return dfs(node, clone);
    }
     private Node dfs(Node node, Dictionary<Node,Node> clone){
        if(node == null) return null;
        if(clone.ContainsKey(node)) return clone[node];

        Node copy = new Node(node.val);
        clone[node] = copy;

        foreach(Node neighbor in node.neighbors){
            copy.neighbors.Add(dfs(neighbor, clone));
        }
        return copy;
    }
}