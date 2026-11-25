public class Solution {
    public int MinLength(string s) {
        Stack<char> stack = new Stack<char>();
        foreach (char c in s) {
            if (stack.Count > 0 && ((stack.Peek() == 'A' && c == 'B') || (stack.Peek() == 'C' && c == 'D'))) {
                stack.Pop();
            } else {
                stack.Push(c);
            }
        }
        return stack.Count;
    }
}
