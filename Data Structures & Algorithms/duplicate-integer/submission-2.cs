public class Solution
{
    public bool hasDuplicate(int[] nums)
    {
        bool hasDuplicate = false;
       for(int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                {
                    hasDuplicate = true;
                    break;
                }
            }
        }
        return hasDuplicate;
    }
}