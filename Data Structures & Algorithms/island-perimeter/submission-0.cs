public class Solution {
    public int IslandPerimeter(int[][] grid) {
        int perimeter = 0;
        for(int i = 0; i < grid.Length; i++){
            for(int j = 0; j < grid[0].Length; j++){
                if(grid[i][j] == 0) continue;
                if(i == 0 || grid[i-1][j] == 0) perimeter += 2;
                if(j == 0 || grid[i][j-1] == 0) perimeter += 2;
            }
        }
        return perimeter;
    }
}