public class Solution {
    public int ArraySign(int[] nums) {
        int n = 0;
        bool zero = false;
        foreach(int num in nums){
            if(num < 0) n++;
            else if (num == 0) zero = true; 
        }
        if(zero) return 0;
        if(n % 2 == 1) return -1;
        else return 1;
    }
}