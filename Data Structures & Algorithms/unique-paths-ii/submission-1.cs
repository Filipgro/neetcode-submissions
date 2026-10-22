public class Solution {
    private int rows,cols;
    private int[][] dp;
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        rows = obstacleGrid.Length;
        cols = obstacleGrid[0].Length;
        dp = new int[rows][];
        for(int i = 0; i < rows; i++){
            dp[i] = new int[cols];
        }
        for(int i = 0; i < rows; i++){
            for(int j = 0; j < cols; j++){
                dp[i][j] = -1;
            }
        }
        return Dp(0,0,obstacleGrid);
    }
    private int Dp(int r, int c, int[][] grid){
        if(r >= rows || c >= cols || grid[r][c] == 1) return 0;
        if(r == rows-1 && c == cols-1) return 1;
        if(dp[r][c] != -1) return dp[r][c];

        dp[r][c] = Dp(r+1,c,grid)+Dp(r,c+1,grid);
        return dp[r][c];
    }
}