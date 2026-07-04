public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int leftProduct = 1;
        int rightProduct = 1;
        var result = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++)
        {
            result[i] = leftProduct;
            leftProduct *= nums[i];
        }
        for(int i = nums.Length - 1; i >= 0; i--)
        {
            result[i] *= rightProduct;
            rightProduct *= nums[i];
        }
        return result;
    }
}
