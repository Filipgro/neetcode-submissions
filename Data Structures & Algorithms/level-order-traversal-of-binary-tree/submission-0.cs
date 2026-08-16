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
    public List<List<int>> LevelOrder(TreeNode root) {
        List<List<int>> res = new List<List<int>>();
        Queue<TreeNode> queue=new Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Count>0){
            int qLen= queue.Count;
            List<int> level=new List<int>();
            for(int i=0;i<qLen;i++){
                TreeNode node=queue.Dequeue();
                if(node!=null){
                    level.Add(node.val);
                    queue.Enqueue(node.left);
                    queue.Enqueue(node.right);
                }
            }
            if(level.Count>0){
                res.Add(level);
            }
        }
        return res;
    }
}
