public class Solution {
    List<List<int>> res = new List<List<int>>();
    public List<List<int>> PermuteUnique(int[] nums) {
        Array.Sort(nums);
        Backtracking(0, nums);
        return res;
    }
    private void Backtracking(int i, int[] nums){
        if(i==nums.Length){
            res.Add(new List<int>(nums));
            return;
        }
        for(int j = i; j<nums.Length;j++){
            if(j>i && nums[i]==nums[j]) continue;
              Swap(nums,i,j);
            Backtracking(i+1, nums);
        }
        for(int j = nums.Length-1; j>i;j--){
            Swap(nums,i,j);
        }
    }
    private void Swap(int[] nums, int i, int j){
        int temp  = nums[i];
        nums[i]=nums[j];
        nums[j]=temp;
    }
}