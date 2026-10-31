public class Solution {
    public bool IsMonotonic(int[] nums) {
        bool up = true;
        bool down = true;

        for(int i = 0; i < nums.Length-1; i++){
            if(nums[i] <= nums[i+1]) continue;
            else up = false;
        }

        for(int i = 0; i < nums.Length-1; i++){
            if(nums[i] >= nums[i+1]) continue;
            else down = false;
        }

        return (up || down);
    }
}