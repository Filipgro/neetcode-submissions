public class Solution {
    public int Tribonacci(int n) {
        return dp(n);
    }
    private int dp(int n){
        if(n == 0) return 0;
        if(n <= 2) return 1;
        int[] dp = new int[3] {0,1,1};
        int i = 3;
        while(i <= n){
            int temp = dp[0] + dp[1] + dp[2];
            dp[0] = dp[1];
            dp[1] = dp[2];
            dp[2] = temp;
            i++;
        }
        return dp[2];
    }
}