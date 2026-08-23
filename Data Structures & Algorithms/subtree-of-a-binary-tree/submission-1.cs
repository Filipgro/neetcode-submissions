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
    private bool sameTree(TreeNode r, TreeNode subR){
        if(r==null && subR==null){
            return true;
        }
        if(r!=null && subR!=null && r.val==subR.val){
            return (sameTree(r.left,subR.left) && sameTree(r.right,subR.right));
        }
        return false;
    }  
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if(subRoot==null){
            return true;
        }
        if(root==null){
            return false;
        }
       if(sameTree(root,subRoot)){
            return true;
        }
         return (IsSubtree(root.left,subRoot) || IsSubtree(root.right,subRoot));
    }
}
