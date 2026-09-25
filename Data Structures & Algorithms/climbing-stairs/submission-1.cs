public class Solution {
    public int ClimbStairs(int n) {
        return dp(n);
    }
    private int dp(int n){
        if(n<2){
            return 1;
        }
       int[] dp = new int[2] {1,1};
       int i = 2;
       while(i<=n)
       {
            int temp = dp[1];
            dp[1]=dp[1]+dp[0];
            dp[0]=temp;
            i++;
       }
       return dp[1];
    }
}