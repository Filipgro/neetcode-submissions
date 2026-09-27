public class Solution {
    private int[] memoization;
    public int Rob(int[] nums) {
        memoization = new int[nums.Length];
        Array.Fill(memoization,-1);
        return dp(nums,0);
    }
    private int dp(int[] nums, int i){
        if(i>=nums.Length) return 0;
       if(memoization[i] != -1) return memoization[i];
       memoization[i] = Math.Max(nums[i]+dp(nums,i+2),dp(nums,i+1));
       return memoization[i];
    }
}
