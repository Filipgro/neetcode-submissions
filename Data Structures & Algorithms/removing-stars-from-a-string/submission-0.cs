public class Solution {
    public string RemoveStars(string s) {
        Stack<char> stack = new Stack<char>();
        foreach(char c in s){
            if(stack.Count > 0 && c == '*') stack.Pop();
            else stack.Push(c);
        }
        char[] res = stack.ToArray();
        Array.Reverse(res);
        return new string(res);
    }
}
