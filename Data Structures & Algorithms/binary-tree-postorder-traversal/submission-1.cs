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
    public List<int> PostorderTraversal(TreeNode root) {
        List<int> res=new List<int>();
        dfs(root,res);
        return res;
    }
    private void dfs(TreeNode root, List<int> res){
        if(root==null){
            return ;
        }
        dfs(root.left,res);
        dfs(root.right,res);
        res.Add(root.val);
    }
}