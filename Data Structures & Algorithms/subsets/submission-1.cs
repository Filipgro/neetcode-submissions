public class Solution {
   public List<List<int>> Subsets(int[] nums)
    {
        List<List<int>> subsets = new List<List<int>>();
        List<int> curSet = new List<int>();
        Helper(0, nums, curSet, subsets);
        return subsets;
    }
    public static void Helper(int i, int[] nums, List<int> curSet, List<List<int>> subsets){
        if(i>=nums.Length){
            subsets.Add(new List<int>(curSet));
            return;
        }
        curSet.Add(nums[i]);
        Helper(i+1,nums,curSet,subsets);
        curSet.RemoveAt(curSet.Count-1);

        Helper(i+1,nums,curSet,subsets);
    }
}
