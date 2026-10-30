public class Solution {
    private int rows, cols;
    public int NumEnclaves(int[][] grid) {
        rows = grid.Length;
        cols = grid[0].Length;
        int res = 0;
        for(int r = 0; r < rows; r++){
            if(grid[r][0] == 1) Dfs(r,0,grid);
            if(grid[r][cols-1] == 1) Dfs(r,cols-1,grid);
        }
        for(int c = 0; c < cols; c++){
            if(grid[0][c] == 1) Dfs(0,c,grid);
            if(grid[rows-1][c] == 1) Dfs(rows-1,c,grid);
        }
        for(int i = 0; i < rows; i++){
            for(int j = 0; j < cols; j++){
                if(grid[i][j] == 1) res++;
            }
        }
        return res;
    }
    private void Dfs(int r, int c,int[][] grid){
        if(r < 0 || c < 0 || r >= rows || c >= cols || grid[r][c] == 0) return;

        grid[r][c] = 0;

        Dfs(r+1,c,grid);
        Dfs(r-1,c,grid);
        Dfs(r,c+1,grid);
        Dfs(r,c-1,grid);
    }
}