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
    public bool HasPathSum(TreeNode root, int targetSum) {
        bool dfs(TreeNode node, int curSum) {
            if (node == null) return false;
            curSum += node.val;

            if (node.left == null && node.right == null) {
                return curSum == targetSum;
            }

            return dfs(node.left, curSum) || dfs(node.right, curSum);
        }
        return dfs(root, 0);
    }
}