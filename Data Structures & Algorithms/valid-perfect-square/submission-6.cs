public class Solution {
    public bool IsPerfectSquare(int num) {
        int left = 1;
        int right = num;
        while(left <= right){
            int mid = left + (right-left)/2;
            long check = (long)mid*mid;
            if(check == num) return true;
            else if(check < num) left = mid+1;
            else right = mid-1;
        }
        return false;
    }
}