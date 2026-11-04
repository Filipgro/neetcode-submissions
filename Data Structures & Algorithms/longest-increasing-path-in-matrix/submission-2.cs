public class Solution {
    private int rows,cols;
    private int[][] memo;
    private int[][] dirs = new int[][] { 
                                        new int[] {1, 0}, 
                                        new int[] {-1, 0}, 
                                        new int[] {0, 1}, 
                                        new int[] {0, -1} 
                                    };
    public int LongestIncreasingPath(int[][] matrix) {
        rows = matrix.Length;
        cols = matrix[0].Length;

        memo = new int[rows][];
        for(int i = 0; i < rows; i++){
            memo[i] = new int[cols];
            Array.Fill(memo[i], -1);
        }
        
        int bestLen = 0;
        for(int r = 0; r < rows; r++){
            for(int c = 0; c < cols; c++){
               bestLen = Math.Max(Dfs(r,c,matrix),bestLen);
            }
        }

        return bestLen;
    }
    private int Dfs(int r, int c, int[][] grid){
        if(memo[r][c] != -1) return memo[r][c];

        int count = 1;
        foreach (var d in dirs) {
            int nr = r + d[0], nc = c + d[1];
            if (nr >= 0 && nr < rows && nc >= 0 && nc < cols && grid[nr][nc] > grid[r][c]) {
                count = Math.Max(count, 1 + Dfs(nr, nc, grid));
            }
        }

        return memo[r][c] = count;
    }
}