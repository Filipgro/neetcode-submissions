public class Solution {
    public bool CanPartition(int[] nums) {
        int sum = 0;
        foreach(int n in nums){
            sum+=n;
        }
        if(sum % 2 != 0) return false;

        int target = sum/2;
        bool[] dp = new bool[target+1];
        dp[0] = true;
        foreach(int n in nums){
            for(int j = target; j >= n; j--){
                dp[j] = dp[j] || dp[j-n];
            }
        }
        return dp[target];
    }
}