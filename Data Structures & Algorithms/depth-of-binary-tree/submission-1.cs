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
    public int MaxDepth(TreeNode root) {
        Queue<TreeNode> queue = new Queue<TreeNode>();
        if (root != null) {
        queue.Enqueue(root);
        }
        int level = 0;
        while (queue.Count > 0) {
            int levelLength = queue.Count;
            for (int i = 0; i < levelLength; i++) {
                TreeNode curr = queue.Dequeue();
                if (curr.left != null) {
                 queue.Enqueue(curr.left);
                }
                if (curr.right != null) {
                    queue.Enqueue(curr.right);
                }
            }
            level++;
        } 
        return level;
    }
}
