public class Solution {
    public List<List<int>> PacificAtlantic(int[][] heights) {
        List<List<int>> res = new List<List<int>>();
        int rows = heights.Length;
        int cols = heights[0].Length;

        bool[][] pacific = new bool[rows][];
        bool[][] atlantic = new bool[rows][];

        for (int r = 0; r < rows; r++)
        {
            pacific[r] = new bool[cols];
            atlantic[r] = new bool[cols];
        }

        for(int c = 0; c < cols; c++){
            Dfs(0,c,heights,pacific);
        }
        for(int r = 0; r < rows; r++){
            Dfs(r,0,heights,pacific);
        }

        for(int c = cols-1; c >= 0; c--){
            Dfs(rows-1,c,heights,atlantic);
        }
         for(int r = rows-1; r >= 0; r--){
            Dfs(r,cols-1,heights,atlantic);
        }

        for(int i = 0; i < rows; i++){
            for(int j = 0; j < cols; j++){
                if(pacific[i][j] && atlantic[i][j]) res.Add(new List<int> {i, j});
            }
        }
        return res;
    }
    private void Dfs(int r, int c, int[][] heights, bool[][] visited){
        int rows = heights.Length;
        int cols = heights[0].Length;

        if (r < 0 || c < 0 || r >= rows || c >= cols || visited[r][c]) return;

        visited[r][c] = true;

        if(r > 0 && heights[r-1][c] >= heights[r][c]) Dfs(r-1,c,heights,visited);
        if(r+1 < rows && heights[r+1][c] >= heights[r][c]) Dfs(r+1,c,heights,visited);
        if(c > 0 && heights[r][c-1] >= heights[r][c]) Dfs(r,c-1,heights,visited);
        if(c+1 < cols && heights[r][c+1] >= heights[r][c]) Dfs(r,c+1,heights,visited);
    }
}
