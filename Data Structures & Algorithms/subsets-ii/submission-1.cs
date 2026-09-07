public class Solution {
    public List<List<int>> SubsetsWithDup(int[] nums) {
        Array.Sort(nums);
        List<List<int>> subset = new List<List<int>>();
        List<int> curSet = new List<int>();
        Helper(0,nums,subset,curSet);
        return subset;
    }
    public static void Helper(int i , int[] nums, List<List<int>> subset, List<int> curSet){
        if(i==nums.Length){
            subset.Add(new List<int>(curSet));
            return;
        }
        curSet.Add(nums[i]);
        Helper(i+1,nums,subset,curSet);
        curSet.RemoveAt(curSet.Count-1);

        while(i + 1 < nums.Length && nums[i] == nums[i + 1]){
            i++;
        }
        Helper(i+1,nums,subset,curSet);
    }
}
