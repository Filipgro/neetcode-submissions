public class Solution {
    public int DiagonalSum(int[][] mat) {
        int res = 0;
        int n = mat.Length;
        for(int r = 0; r < n; r++){
            res += mat[r][r];
            res += mat[r][n-r-1];
        }
        if(n % 2 == 1) res -= mat[n/2][n/2];
        return res;
    }
}