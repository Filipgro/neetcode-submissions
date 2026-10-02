public class Solution {  
    private void Backtrack(int openN,int closeN, int n, List<string> res, string s){
        if(openN == n && closeN== n){
            res.Add(s);
            return;
        }

        if(openN < n){
            Backtrack(openN+1,closeN,n,res,s +'(');
        }

        if(closeN < openN){
            Backtrack(openN,closeN+1,n,res,s +')');
        }
    }
    public List<string> GenerateParenthesis(int n) {
        List<string> res = new List<string>();
        string s = "";
        Backtrack(0,0,n,res,s);
        return res;
    }
}
