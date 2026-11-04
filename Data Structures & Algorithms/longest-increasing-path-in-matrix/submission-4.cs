public class Solution {
    private int rows,cols;
    private int[][] memo;
    private int[][] directions = new int[][]{
        new int[] {1,0},
        new int[] {-1,0},
        new int[] {0,1},
        new int[] {0,-1}
    };
    public int LongestIncreasingPath(int[][] matrix) {
        rows = matrix.Length;
        cols = matrix[0].Length;

        memo = new int[rows][];
        for(int i = 0; i < rows; i++){
            memo[i] = new int[cols];
            Array.Fill(memo[i],-1);
        }

        int res = 0;
        for(int r = 0; r < rows; r++){
            for(int c = 0; c < cols; c++){
                res = Math.Max(res,Dfs(r,c,matrix));
            }
        }
        return res;
    }
    private int Dfs(int r, int c, int[][] grid){
        if(memo[r][c] != -1) return memo[r][c];

        int count = 1;
        foreach(int[] dir in directions){
            int nr = r+dir[0];
            int nc = c+dir[1];
            if(nr >= 0 && nc >= 0 && nr < rows && nc < cols && grid[nr][nc] > grid[r][c]){
                count = Math.Max(count,1+Dfs(nr,nc,grid));
            }
        }

        return memo[r][c] = count;
    }
}