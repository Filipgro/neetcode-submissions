public class Solution {
    public bool ValidPalindrome(string s) {
        int l = 0;
        int r = s.Length-1;
        while(l < r){
            if(s[l] == s[r]){
                l++;
                r--;
            }else{
                return (isPali(l+1,r,s) || isPali(l,r-1,s));
            }
        }
        return true;
    }
    private bool isPali(int l, int r, string s){
        while(l < r){
            if(s[l] != s[r]) return false;
            l++;
            r--;
        }
        return true;
    }
}