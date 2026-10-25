public class Solution {
    private int rows,cols;
    private int[] dir = {0,1,0,-1,0};
    public int ClosedIsland(int[][] grid) {
        rows = grid.Length;
        cols = grid[0].Length;
        for(int r = 0; r < rows; r++){
            dfs(grid,r,0);
            dfs(grid,r,cols-1);
        }
        for(int c = 0; c < cols; c++){
            dfs(grid,0,c);
            dfs(grid,rows-1,c);
        }

        int res = 0;
        for(int r = 1; r < rows-1; r++){
            for(int c = 1; c < cols-1; c++){
                if(grid[r][c] == 0){
                    dfs(grid,r,c);
                    res++;
                }
            }
        }
        return res;
    }
    private void dfs(int[][] grid, int r , int c){
        if(r >= rows || c >= cols || r < 0 || c < 0 || grid[r][c] == 1){
            return;
        }
        grid[r][c] = 1;
        for(int i = 0; i < 4; i++){
            dfs(grid,r+dir[i],c+dir[i+1]);
        }
    }
}