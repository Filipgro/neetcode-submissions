public class Solution {
    public string ClearDigits(string s) {
        Stack<char> stack = new Stack<char>();
        foreach(char c in s){
            if(stack.Count > 0 && char.IsDigit(c)) stack.Pop();
            else stack.Push(c);
        }
        char[] arr = stack.ToArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}