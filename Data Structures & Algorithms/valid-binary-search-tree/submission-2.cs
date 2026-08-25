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
    public bool valid(TreeNode node,int l,int r){
            if(node==null){
                return true;
            }
            if(node.val <= l || node.val >= r){
                return false;
            }
            return (valid(node.left,l,node.val) && valid(node.right,node.val,r));
        }
    public bool IsValidBST(TreeNode root) {
        return valid(root,int.MinValue,int.MaxValue);
    }
}
