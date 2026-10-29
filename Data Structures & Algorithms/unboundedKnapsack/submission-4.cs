public class Solution {
    public int MaximumProfit(List<int> profit, List<int> weight, int capacity) {
        int rows = profit.Count;
        int cols = capacity;
        int[] dp = new int[cols+1];

        for(int c = 0; c <= cols; c++){
            if(weight[0] <= c) dp[c] = (c / weight[0]) * profit[0];
        }

        for(int i = 0; i < rows; i++){
            int[] curRow = new int[cols+1];
            Array.Fill(curRow,0);
            for(int c = 0; c <= cols; c++){
                int skip = dp[c];
                int include = 0;
                if(c-weight[i] >= 0){
                    include = profit[i] + curRow[c-weight[i]];
                }
                curRow[c] = Math.Max(skip,include);
            }
            dp = curRow;
        }
        return dp[cols];
    }
}
