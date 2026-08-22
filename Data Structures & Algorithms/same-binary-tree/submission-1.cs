/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    private bool dfs(TreeNode node1, TreeNode node2){
        if(node1==null && node2==null){
            return true;
        }
        if (node1 == null || node2 == null){
            return false;
        }

        bool left = dfs(node1.left, node2.left);
        bool right = dfs(node1.right, node2.right);

        return node1.val==node2.val && left && right;
    }
    
    public bool IsSameTree(TreeNode p, TreeNode q) {
        return dfs(p,q);
    }
}
