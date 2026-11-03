public class Solution {
    public int ArraySign(int[] nums) {
        int n = 0;
        bool z = false;
        foreach(int num in nums){
            if(num < 0) n++;
            else if(num == 0) z = true;
        }
        if(z) return 0;
        return n % 2 == 0 ? 1:-1;
    }
}