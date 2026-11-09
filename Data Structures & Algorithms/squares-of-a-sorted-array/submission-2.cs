public class Solution {
    public int[] SortedSquares(int[] nums) {
        int[] res = nums.OrderBy(x => Math.Abs(x)).ToArray();
        for(int i = 0; i < nums.Length; i++){
            res[i] = res[i] * res[i];
        }
        return res;
    }
}