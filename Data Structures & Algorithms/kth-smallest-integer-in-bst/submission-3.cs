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
    public int KthSmallest(TreeNode root, int k) {
        List<int> res=new List<int>();
        return dfs(root,res,k);
    }
    private int dfs(TreeNode node, List<int> res, int k){
        if(node==null){
            return 0;
        }
        dfs(node.left,res,k);
        res.Add(node.val);
        if(res.Count == k) return res[k-1];
    
        dfs(node.right, res, k);
        return res.Count >= k ? res[k-1] : 0;
    }
}
