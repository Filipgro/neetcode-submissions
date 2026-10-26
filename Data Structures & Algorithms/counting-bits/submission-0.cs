public class Solution {
    public int[] CountBits(int n) {
        int[] res = new int[n+1];
        for(int i = 0; i < res.Length; i++){
            res[i] = countBits(i);
        }
        return res;
    }
    private int countBits(int n){
        int count = 0;
        while(n != 0){
            if((n & 1) == 1) count++;
            n = n >> 1;
        }
        return count;
    }
}
