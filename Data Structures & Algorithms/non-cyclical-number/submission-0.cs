public class Solution {
    public bool IsHappy(int n) {
        if(n==1 || n==1000) return true;
        HashSet<int> seen = new HashSet<int>();
        while(true){
            if(digitSquared(n)==1){
                return true;
            }else if (!seen.Add(digitSquared(n))){
                return false;
            }
            n=digitSquared(n);
        }
    }
    private int digitSquared(int n){
        int sum = 0;
        while(n!=0){
            int digit=n%10;
            sum+=digit*digit;
            n/=10;
        }
        return sum;
    }
}
