public class Solution {
    public bool ValidateStackSequences(int[] pushed, int[] popped) {
        int i = 0;
        Stack<int> stack = new Stack<int>();
        foreach(int n in pushed){
            stack.Push(n);
            while(i < popped.Length && stack.Count > 0 && popped[i] == stack.Peek())
            {
                stack.Pop();
                i++;
            }
        }
        return stack.Count == 0 ? true:false;
    }
}
