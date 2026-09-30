public class Solution {
    public string LongestPalindrome(string s) {
        string res = "";
        for(int i = 0; i < s.Length; i++){
            string odd = helper(i,i,s);
            string even = helper(i,i+1,s);
            if(odd.Length > res.Length){
                res = odd;
            }
            if(even.Length > res.Length){
                res = even;
            }
        }
        return res;
    }
    private string helper(int l, int r, string s){
        string longest = "";
        while(l >= 0 && r < s.Length && s[l] == s[r]){
            string cur = s.Substring(l,r-l+1);
            if(cur.Length > longest.Length){
                longest = cur;
            }
            l--;
            r++;
        }
        return longest;
    }
}
