public class Solution {
    public void MoveZeroes(int[] nums) {
        Stack<int> stack = new Stack<int>();
        foreach(int n in nums){
            if(n!=0) stack.Push(n);
        }
        var reversed = new Stack<int>(stack);
        for(int i = 0; i < nums.Length; i++){
            if(reversed.Count > 0)
            {   
                nums[i] = reversed.Pop();
            }
            else
            {   
                nums[i] = 0;
            }
        }
    }
}