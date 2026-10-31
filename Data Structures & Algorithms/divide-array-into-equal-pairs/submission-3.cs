public class Solution {
    public bool DivideArray(int[] nums) {
        HashSet<int> unique = new HashSet<int>();
        for(int i = 0; i < nums.Length; i++){
            if (!unique.Add(nums[i])) {
                unique.Remove(nums[i]);
            }
        }
        return unique.Count == 0;
    }
}