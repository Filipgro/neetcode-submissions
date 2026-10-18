public class Solution {
    private static readonly int[][] directions =
    {
        new int[] { 0, 1 },   
        new int[] { 0, -1 },  
        new int[] { 1, 0 },   
        new int[] { -1, 0 }
    };
    public void islandsAndTreasure(int[][] grid) {
        int rows = grid.Length;
        int cols = grid[0].Length;
        Queue<int[]> q = new Queue<int[]>();
        for(int i = 0; i < rows; i++){
            for(int j = 0; j < cols; j++){
                if(grid[i][j] == 0) {
                    q.Enqueue(new int[] {i,j});
                }
            }
        }

        while(q.Count > 0){
            int[] cur = q.Dequeue();

            int r = cur[0];
            int c = cur[1];

            foreach(int[] dir in directions){
                int row = r + dir[0];
                int col = c + dir[1];

                if( row < 0 || grid.Length <= row ||
                    col < 0 || grid[0].Length <= col){
                    continue;
                }
                if(grid[row][col] != int.MaxValue) continue;

                grid[row][col] = grid[r][c]+1;
                    
                q.Enqueue(new int[] {row, col});
            }
        }
    }
}