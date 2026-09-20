public class Solution {
    List<List<int>> res;
    public List<List<int>> CombinationSum(int[] nums, int target) {
        res = new List<List<int>>();
        Array.Sort(nums);
        traverse(0, new List<int>(),0,nums,target);
        return res;
    }
    private void traverse(int i, List<int> cur, int total, int[] nums,int target){
        if(total==target){
            res.Add(new List<int>(cur));
            return;
        }
        for(int j=i; j<nums.Length;j++){
            if(total+nums[j]>target){
                return;
            }
            cur.Add(nums[j]);
            traverse(j,cur,total+nums[j],nums,target);
            cur.RemoveAt(cur.Count-1);
        }
        
    }
}
