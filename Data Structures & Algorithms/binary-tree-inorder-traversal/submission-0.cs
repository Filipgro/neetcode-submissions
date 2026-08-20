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
    private void Triverse(TreeNode node,List<int> result){
        if(node==null){
            return;
        }

        Triverse(node.left,result);
        result.Add(node.val);
        Triverse(node.right,result);
    } 

    public List<int> InorderTraversal(TreeNode root) {
        List<int> res=new List<int>();
        Triverse(root,res);
        return res;
    }
}