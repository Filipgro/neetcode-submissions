public class Solution {
    public int TotalMoney(int n) {
        int sum = 0;
        for(int day = 0; day < n; day++){
            int week = day/7;
            int dayOfWeek = day%7;

            sum+= week + 1 + dayOfWeek;
        }
        return sum;
    }
}
