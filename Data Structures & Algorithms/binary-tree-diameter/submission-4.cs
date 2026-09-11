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
    private int res=0;

    private int dfs(TreeNode node){
        if(node==null){
            return 0;
        }
        int left=dfs(node.left);
        int right=dfs(node.right);
        res=Math.Max(res,left+right);
        return 1+Math.Max(left,right);
    }

    public int DiameterOfBinaryTree(TreeNode root) {
        res=0;
        dfs(root);
        return res;
    }
}
