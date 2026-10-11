public class Solution {
    static readonly int[][] directions =
    {
        new int[] { 0, 1 },   
        new int[] { 0, -1 },  
        new int[] { 1, 0 },   
        new int[] { -1, 0 }   
    };
    public int OrangesRotting(int[][] grid) {
        Queue<int[]> q = new Queue<int[]>();
        int rows = grid.Length;
        int cols = grid[0].Length;
        int time = 0;
        int fresh = 0;
        for(int i = 0; i < rows; i++){
            for(int j = 0; j < cols; j++){
                if(grid[i][j] == 1) fresh++;
                else if(grid[i][j] == 2) q.Enqueue(new int[] { i, j});
            }
        }
        while(q.Count > 0 && fresh > 0){
            int len = q.Count;
            for(int i = 0; i < len ; i++){
                int[] cur = q.Dequeue();
                int r = cur[0];
                int c = cur[1];

                foreach(int[] dir in directions){
                    int row = r+dir[0];
                    int col = c+dir[1];

                    if(row >= 0 && grid.Length > row &&
                        col >= 0 && grid[0].Length > col &&
                        grid[row][col] == 1){
                            grid[row][col] = 2;
                            q.Enqueue(new int[] { row, col});
                            fresh--;
                        }
                }
            }
            time++;
        }
        return fresh == 0 ? time : -1;
    }
}
