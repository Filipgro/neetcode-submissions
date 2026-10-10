public class Solution {
    public int MaximumProfit(List<int> profit, List<int> weight, int capacity) {
        int rows = profit.Count;
        int col = capacity;
        int[,] dp = new int[rows, col + 1];

        for (int i = 0; i < rows; i++) dp[i, 0] = 0;
        for (int c = 0; c <= col; c++) {
            if (weight[0] <= c) dp[0, c] = profit[0];
        }

        for (int i = 1; i < rows; i++) {
            for (int c = 0; c <= col; c++) {
                int skip = dp[i - 1, c];
                int include = 0;
                if (c - weight[i] >= 0) {
                    include = profit[i] + dp[i - 1, c - weight[i]];
                }
                dp[i, c] = Math.Max(include, skip);
            }
        }
        return dp[rows - 1, col];
    } 
}