public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> stack = new Stack<int>();
        foreach(string op in operations){
            if(op == "+"){
                int top = stack.Pop();
                int res = top + stack.Peek();
                stack.Push(top);
                stack.Push(res);
            }else if(op == "D"){
                stack.Push(stack.Peek()*2);
            }else if(op == "C"){
                stack.Pop();
            }else{
                stack.Push(int.Parse(op));
            }
        }
        int points = 0;
        foreach(int score in stack){
            points += score;
        }
        return points;
    }
}