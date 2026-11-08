public class Solution {
    public long GridGame(int[][] grid) {
        int n = grid[0].Length;
        long topSum = 0;
        for (int i = 0; i < n; i++) {
            topSum += grid[0][i];
        }
        long bottomSum = 0;
        long minSecondScore = long.MaxValue;

        for (int i = 0; i < n; i++) {
            topSum -= grid[0][i];
            long secondScore = Math.Max(topSum, bottomSum);
            minSecondScore = Math.Min(minSecondScore, secondScore);
            bottomSum += grid[1][i];
        }

        return minSecondScore;
    }
}