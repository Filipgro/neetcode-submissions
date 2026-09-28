public class Solution {
    private int[] memo;
    public int Rob(int[] nums) {
        if (nums.Length == 1) return nums[0];
        
        memo = new int[nums.Length];
        int[] nums1 = new int[nums.Length-1];
        int[] nums2 = new int[nums.Length-1];
        for(int i = 0; i< nums.Length-1;i++){
            nums1[i]=nums[i];
            nums2[i]=nums[i+1];
        }
        Array.Fill(memo,-1);
        int rob1 = dp(nums1,0);

        Array.Fill(memo,-1);
        int rob2 = dp(nums2,0);

        return Math.Max(rob1,rob2);
    }
    private int dp(int[] arr, int i) {
        if (i >= arr.Length) return 0;
        if (memo[i] != -1) return memo[i];

        memo[i] = Math.Max(arr[i] + dp(arr, i + 2), dp(arr, i + 1));
        return memo[i];
    }
}