public class Solution {
    public double AverageWaitingTime(int[][] customers) {
        long curTime = 0;
        double res = 0;

        foreach(int[] customer in customers){
            curTime = Math.Max(curTime, customer[0]) + customer[1];
            res += curTime - customer[0];
        }
        return res/customers.Length;
    }
}