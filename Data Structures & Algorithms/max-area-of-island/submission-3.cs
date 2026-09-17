public class Solution {
    private static readonly int[][] directions = {
        new int[] {1,0},
        new int[] {-1,0},
        new int[] {0,1},
        new int[] {0,-1}
    };

    public int MaxAreaOfIsland(int[][] grid) {
        if(grid==null || grid.Length==0 || grid[0].Length==0){
            return 0;
        }
        int rows = grid.Length;
        int colums = grid[0].Length;
        int maxArea = 0;

        for(int r=0;r<rows;r++){
            for(int c=0;c<colums;c++){
                if(grid[r][c]==1){
                    int area = bfs(grid,r,c);
                    if(area>maxArea){
                        maxArea=area;
                    }
                }
            }
        }
        return maxArea;
    }
    private int bfs(int[][] grid, int r, int c){
        Queue<int[]> q = new Queue<int[]>();
        grid[r][c]=0;
        q.Enqueue(new int[] {r,c});
        int islandArea = 1;

        while(q.Count>0){
            int[] body = q.Dequeue();
            int row = body[0];
            int col = body[1];

            foreach(int[] dir in directions){
                int nextRow = row+dir[0];
                int nextCol = col+dir[1];
               if(nextRow>=0 &&
                  nextCol>=0 &&
                  nextRow<grid.Length &&
                  nextCol<grid[0].Length &&
                  grid[nextRow][nextCol]==1) 
                {
                    islandArea++;
                    grid[nextRow][nextCol]=0;
                    q.Enqueue(new int[] {nextRow,nextCol});
                }
            }
        }
        return islandArea;
    }
}
