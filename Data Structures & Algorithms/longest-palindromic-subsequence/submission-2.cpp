class Solution {
    int solve(vector<vector<int>>& dp,string& s, int l, int r)
    {
        if(l > r)
            return 0;

        if(dp[l][r] != -1)
            return dp[l][r];

        if(s[l] == s[r])
        {
            dp[l][r] = 2 + solve(dp, s, l+1, r-1);
        }else{
            dp[l][r] = max(solve(dp, s, l+1, r), solve(dp, s, l, r-1));
        }

        return dp[l][r];
    }
public:
    int longestPalindromeSubseq(string s) {
        vector<vector<int>> dp(s.size(), vector<int>(s.size(), -1));
        for(int i=0;i<s.size();i++)
            dp[i][i] = 1;


        return solve(dp, s, 0, s.size()-1);

        
    }

};