public class Solution {
    public string SimplifyPath(string path) {
        Stack<string> stack = new Stack<string>();
        string cur = "";

        foreach(char c in path + '/'){
            if(c == '/'){
                if(cur == ".."){
                    if(stack.Count > 0){
                        stack.Pop();
                    }
                }else if(cur != "" && cur != "."){
                    stack.Push(cur);
                }
                cur = "";
            }else{
                cur += c;
            }
        }
        List<string> res = new List<string>(stack);
        res.Reverse();
        return "/" + string.Join("/",res);
    }
}