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
    public TreeNode InvertTree(TreeNode root) {
        Queue<TreeNode> q=new Queue<TreeNode>();
        q.Enqueue(root);
        while(q.Count>0){
            int qlen=q.Count;
            for(int i=0;i<qlen;i++){
                TreeNode node=q.Dequeue();
                if(node!=null){
                    TreeNode temp=node.left;
                    node.left=node.right;
                    node.right=temp;
                    q.Enqueue(node.left);
                    q.Enqueue(node.right);
                }
            }
        }
        return root;
    }   
}
