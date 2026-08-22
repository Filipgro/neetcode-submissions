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
     (bool balanced, int height) dfs(TreeNode root) {
        if(root==null){
            return (true,0);
        }
        var left=dfs(root.left);
        var right=dfs(root.right);
        bool balanced= left.balanced && right.balanced && 
                        Math.Abs(left.height-right.height)<=1;

        return (balanced, 1 + Math.Max(left.height, right.height));
    }
    public bool IsBalanced(TreeNode root) {
        return dfs(root).balanced;
    }
}
