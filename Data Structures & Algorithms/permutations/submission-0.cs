public class Solution {
    List<List<int>> res;
    public List<List<int>> Permute(int[] nums) {
        res= new List<List<int>>();
        Permutations(0,nums);
        return res;
    }
    private void Permutations(int i, int[] nums){
        if(i==nums.Length){
            res.Add(new List<int>(nums));
            return;
        }
        for(int j = i; j<nums.Length;j++){
            int temp = nums[i];
            nums[i]=nums[j];
            nums[j]=temp;

            Permutations(i+1,nums);
            
            temp = nums[i];
            nums[i]=nums[j];
            nums[j]=temp;            
        }
    }
}
