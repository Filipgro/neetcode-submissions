public class Solution {
    public int NumWaterBottles(int numBottles, int numExchange) {
        if(numBottles < numExchange) return numBottles;

        int res = numBottles;
        int empty = numBottles;
        while(empty >= numExchange){
            res += empty/numExchange;
            empty = (empty/numExchange) + (empty%numExchange);
        }
        return res;
    }
}
