public class Solution {
    public int CountSubstrings(string s) {
        int res = 0;
        for(int i = 0; i < s.Length; i++){
            res += PaliCount(i,i,s);
            res += PaliCount(i,i+1,s);
        }
        return res;
    }
    private int PaliCount(int l, int r, string s){
        int res = 0;
        while(l >= 0 && r < s.Length && s[l] == s[r]){
            res++;
            l--;
            r++;
        }
        return res;
    }
}
