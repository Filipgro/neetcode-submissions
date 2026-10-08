public class Solution {
    public int MySqrt(int x) {
        long l = 0;
        long r = x;
        long ans = 0;
        while(l <= r){
            long mid = l + (r - l)/2;
            long check = mid * mid;
            if(check == x) return (int)mid;
            else if(check < x) {
                ans = mid;
                l = mid + 1;
            }
            else r = mid - 1; 
        }
        return (int)ans;
    }
}